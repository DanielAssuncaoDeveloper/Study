import prompt from 'readline';
import util from 'util';

const rl = prompt.createInterface({ input: process.stdin, output: process.stdout });
const question = util.promisify(rl.question).bind(rl);

const readLine = async (msg) => {
    const resp = await question(`${msg??''}\n`);  
    rl.close();

    return resp;
} 

export {readLine}