#include <iostream>
#include <map>
#include <utility>
#include <type_traits>

using namespace std;

template<typename K, typename V>
class interval_map {
    friend void IntervalMapTest();

    V m_valBegin;
    std::map<K, V> m_map;

public:
    interval_map() = default;
    template<typename V_forward>
    interval_map(V_forward&& val)
        : m_valBegin(std::forward<V_forward>(val)) {}

    interval_map(const interval_map& other)
        : m_valBegin(other.m_valBegin), m_map(other.m_map) {
        std::cout << "Copy constructor called.\n";
    }
    interval_map& operator=(const interval_map& other) {
        if (this != &other) {
            m_valBegin = other.m_valBegin;
            m_map = other.m_map;
            std::cout << "Copy assignment operator called.\n";
        }
        return *this;
    }

    interval_map(interval_map&& other) noexcept
        : m_valBegin(std::move(other.m_valBegin)), m_map(std::move(other.m_map)) {
        std::cout << "Move constructor called.\n";
    }

    interval_map& operator=(interval_map&& other) noexcept {
        if (this != &other) {
            m_valBegin = std::move(other.m_valBegin);
            m_map = std::move(other.m_map);
            std::cout << "Move assignment operator called.\n";
        }
        return *this;
    }

    ~interval_map() {
        std::cout << "Destructor called.\n";
    }

    template<typename V_forward>
    void assign(const K& keyBegin, const K& keyEnd, V_forward&& val)
        requires (std::is_same_v<std::remove_cvref_t<V_forward>, V>)
    {
        if (!(keyBegin < keyEnd)) return;

        auto itBegin = m_map.lower_bound(keyBegin);
        auto itEnd = m_map.lower_bound(keyEnd);

        V prevValue = (itBegin == m_map.begin()) ? m_valBegin : std::prev(itBegin)->second;

        m_map.erase(itBegin, itEnd);

        if (prevValue != val) {
            m_map.insert({ keyBegin, val }); 
        }

        if (itEnd != m_map.end() && itEnd->second != val) {
            m_map.insert({ keyEnd, itEnd->second });
        }
        else if (itEnd == m_map.end()) {
            m_map.insert({ keyEnd, m_valBegin });
        }
    }

    V const& operator[](const K& key) const {
        auto it = m_map.upper_bound(key);
        if (it == m_map.begin()) {
            return m_valBegin;
        }
        else {
            return (--it)->second;
        }
    }

    void print() const {
        std::cout << "Intervals in interval_map:\n";
        for (auto it = m_map.begin(); it != m_map.end(); ++it) {
            std::cout << "Key: " << it->first << ", Value: " << it->second << '\n';
        }
        std::cout << "Value before first key: " << m_valBegin << '\n';
    }
};

int main() {
    interval_map<int, char> map('A');
    map.assign(1, 5, 'B'); 

    cout << "Assigned 'B' to interval [1, 3).\n";
    map.print();

    cout << "\nTesting operator[]:\n";
    cout << "map[0] = " << map[0] << endl; 
    cout << "map[1] = " << map[1] << endl; 
    cout << "map[2] = " << map[2] << endl; 
    cout << "map[3] = " << map[3] << endl; 
    cout << "map[4] = " << map[4] << endl;
    cout << "map[5] = " << map[5] << endl;
    cout << "map[6] = " << map[6] << endl;
    cout << "map[7] = " << map[7] << endl;
    cout << "map[8] = " << map[8] << endl;
    cout << "map[9] = " << map[9] << endl;

    return 0;
}
