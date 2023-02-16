import axios from "axios";
export default axios.create({
    baseURL: "http://localhost:5292",
    headers: {
        "Content-type": "application/json"
    }
});