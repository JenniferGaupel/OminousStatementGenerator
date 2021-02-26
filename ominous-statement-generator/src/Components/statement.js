import statementData from '../../public/assets/statements.json';
const Statement = () => {
  const data = JSON.parse(statementData);
  const message = "ominous statement";
  message += data.statements.firstStatement[1];
  return <div>{message}</div>;
};

export default Statement;
