export default function useStorage() {

    const localStorage = window.localStorage;
  
    const addItem = (key: string, value: any) => {
      console.log(`Local Storage add key:${key}:`, value);
      localStorage.setItem(key, JSON.stringify(value));
    }
    const removeItem = (key: string) => {
      console.log(`Local Storage removed key:${key}`);
      localStorage.removeItem(key);
    }
    const clear = () => {
      console.log('Local Storage remove all');
      localStorage.clear();
    }
    const readItem = (key: string) => {
      const item = localStorage.getItem(key) as string;
      return JSON.parse(item);
    }
  
    return {
      addItem,
      removeItem,
      clear,
      readItem,
    }
  }
  