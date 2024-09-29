
body { 
    font-family: 'Arial', sans-serif; 
    margin: 0; 
    padding: 0; 
    min-height: 100vh; 
    display: flex; 
    flex-direction: column; 
} 
  
.logo { 
    margin-left: 5%; 
} 
  
a { 
    text-decoration: none; 
    color: black; 
    transition: transform .3s; 
    display: inline-block; 
    font-weight: 700; 
} 
  
a:hover { 
    -ms-transform: scale(1.2, 1.2); 
    -webkit-transform: scale(1.2, 1.2); 
    transform: scale(1.2, 1.2); 
} 
  
nav { 
    margin-right: 5%; 
} 
  
li { 
    list-style: none; 
    display: inline; 
    padding: 15px; 
} 
  
main { 
    flex-grow: 1; 
    display: flex; 
    justify-content: center; 
    align-items: center; 
    padding-top: 80px; 
    padding-bottom: 50px; 
    margin-top: 50px; 
} 
  
header { 
    display: flex; 
    justify-content: space-between; 
    align-items: center; 
    background-color: #f5f5f5; 
    color: white; 
    padding: 15px; 
    position: fixed; 
    width: 100%; 
    z-index: 1000; 
} 
  
footer { 
    background-color: #333; 
    color: white; 
    text-align: center; 
    padding: 0.7rem; 
} 
  
.post-container { 
    margin-left: 5%; 
    margin-right: 5%; 
    display: grid; 
    grid-template-columns: repeat(auto-fill, minmax(280px, 1fr)); 
    justify-content: center; 
    gap: 2.5rem; 
} 
  
.post-box { 
    border: 1px solid black; 
    border-radius: 40px; 
    text-align: center; 
    padding: 15px; 
} 
  
.category { 
    background-color: #3498db; 
    border: 1px solid #ccc; 
    border-radius: 13px; 
    font-size: 16px; 
    color: white; 
    padding: 5px; 
    margin-top: 0px; 
    margin-bottom: 5px; 
    display: inline-block; 
} 
  
.post-title { 
    color: #333; 
    text-decoration: none; 
    font-size: 2rem; 
    font-weight: bold; 
    display: inline-block; 
    margin-bottom: 10px; 
    cursor: pointer; 
    transition: transform 0.3s; 
} 
  
.post-title:hover { 
    -ms-transform: scale(1.1, 1.1); 
    -webkit-transform: scale(1.1, 1.1); 
    transform: scale(1.1, 1.1); 
} 
  
.post-date { 
    color: #777; 
    font-size: 0.9rem; 
    margin-bottom: 10px; 
} 
  
.post-description { 
    margin-top: 5px; 
    color: #555; 
    line-height: 1.5; 
} 
  
/* Styles for the modal */
.modal { 
    z-index: 1000; 
    display: none; 
    position: fixed; 
    top: 0; 
    left: 0; 
    width: 100%; 
    height: 100%; 
    background-color: rgba(0, 0, 0, 0.5); 
    justify-content: center; 
    align-items: center; 
    animation: fadeIn 0.5s ease-in-out; 
} 
  
.modal-content { 
    max-width: 50%; 
    width: 100%; 
    height: 75%; 
    margin: auto; 
    background: rgba(255, 255, 255, 0.67); 
    border-radius: 16px; 
    box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1); 
    backdrop-filter: blur(9.5px); 
    -webkit-backdrop-filter: blur(9.5px); 
    padding: 20px; 
    padding-top: 5px; 
    border-radius: 10px; 
    overflow-y: auto; 
    max-height: 80vh; 
    text-align: center; 
    animation: fadeIn 0.5s ease-in-out; 
} 
  
.modal.fadeOut { 
    animation: fadeOut 0.5s ease-in-out; 
    /* Apply fadeOut animation */
} 
  
@keyframes fadeIn { 
    from { 
        opacity: 0; 
    } 
  
    to { 
        opacity: 1; 
    } 
} 
  
@keyframes fadeOut { 
    from { 
        opacity: 1; 
    } 
  
    to { 
        opacity: 0; 
    } 
} 
  
  
.close { 
    cursor: pointer; 
    font-size: 25px; 
    color: #555; 
    transition: transform .2s; 
    display: inline-block; 
} 
  
.close:hover { 
    -ms-transform: scale(1.7, 1.7); 
    -webkit-transform: scale(1.7, 1.7); 
    transform: scale(1.7, 1.7); 
} 
  
  
.title, 
.category1 { 
    font-weight: bold; 
    margin-bottom: 8px; 
} 
  
.title input, 
.category1 input, 
.postDescription { 
    width: 100%; 
    max-width: 100%; 
    padding: 12px; 
    margin-bottom: 16px; 
    border: 1px solid #ccc; 
    border-radius: 8px; 
    box-sizing: border-box; 
    transition: border-color 0.3s, box-shadow 0.3s; 
} 
  
.postDescription { 
    height: 200px; 
} 
  
.postheading { 
    color: #333; 
    font-weight: bold; 
} 
  
.postTitle:focus, 
.postCategory:focus, 
.postDescription:focus { 
    outline: none; 
    border-color: #3498db; 
    box-shadow: 0 0 8px rgba(52, 152, 219, 0.6); 
} 
  
.postSubmitBtn { 
    background-color: #3498db; 
    color: white; 
    padding: 10px 20px; 
    border: none; 
    border-radius: 5px; 
    cursor: pointer; 
    font-size: 16px; 
    transition: background-color 0.3s; 
} 
  
.postSubmitBtn:hover { 
    background-color: #2980b9; 
} 
  
.post-message { 
    display: none; 
    position: fixed; 
    top: 0; 
    left: 50%; 
    transform: translateX(-50%); 
    background-color: #4CAF50; 
    color: white; 
    text-align: center; 
    padding: 10px; 
    z-index: 1000; 
} 
  
  
.load-more { 
    display: inline-block; 
    color: #3498db; 
    cursor: pointer; 
    font-size: 14px; 
    font-weight: bold; 
    transition: transform 0.3s; 
} 
  
.load-more:hover { 
    color: #2980b9; 
    -ms-transform: scale(1.1, 1.1); 
    -webkit-transform: scale(1.1, 1.1); 
    transform: scale(1.1, 1.1); 
} 
  
#detailTitle { 
    font-size: 50px; 
    margin-bottom: 20px; 
    margin-top: 10px; 
} 
  
.delete-post { 
    background-color: #e74c3c; 
    color: white; 
    padding: 8px 15px; 
    border: none; 
    border-radius: 5px; 
    cursor: pointer; 
    font-size: 14px; 
    margin-top: 10px; 
    margin-right: 120px; 
    transition: background-color 0.3s; 
} 
  
.delete-post:hover { 
    background-color: #c0392b; 
} 
  
@media only screen and (max-width: 550px) { 
  
    li { 
        display: inline; 
        padding: 5px; 
    } 
  
    .post-container { 
        grid-template-columns: 1fr; 
    } 
  
    .modal-content { 
        max-width: 90%; 
    } 
} 
  
@media screen and (max-width : 480px) { 
    h1 { 
        font-size: 30px; 
    } 
  
    li { 
        display: block; 
    } 
  
    ul { 
        padding-right: 5%; 
    } 
  
    header { 
        padding: 0px; 
        display: flex; 
        text-align: center; 
    } 
  
    .post-container { 
        margin-top: 80px; 
    } 
  
} 
  
@media screen and (max-width : 380px) { 
  
    header { 
        padding: 0px; 
        display: flex; 
        text-align: center; 
    } 
  
    .logo { 
        margin-left: 5%; 
    } 
  
}