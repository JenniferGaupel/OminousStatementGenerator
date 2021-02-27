import statementData from '../assets/statements.json';
const Statement = () => {
  var random1 = Math.floor(Math.random() * 11);
  var random2 = Math.floor(Math.random() * 5);;
  var random3 = Math.floor(Math.random() * 3);;
  var random4 = Math.floor(Math.random() * 5);;

  var  message = statementData.statements.firstStatement[random1] + statementData.statements.secondStatement[random2] 
                  + statementData.statements.thirdStatement[random3] + statementData.statements.fourthStatement[random4];
  return <div>{message}</div>;
};

export default Statement;
