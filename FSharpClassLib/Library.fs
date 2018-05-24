namespace ClassLibrary1

module Say =
    let helloAsync name =
        async {
            let res = sprintf "Hello %s" name
            return res
        } |> Async.StartAsTask
