import React, { useEffect, useState } from 'react'
import Pills from './TopButtons'
export default function YouPage() {
  const [studens,getStudents] = useState([])
  useEffect(()=>{
    
  })
  return ( 
    <div>
      <Pills/>
      <div>
      <div class="px-4 py-5 my-2 text-center">

    <h1 class="display-5 fw-bold text-body-emphasis">Welcome</h1>
    <div class="col-lg-6 mx-auto">  
      <div class="d-grid gap-2 d-sm-flex justify-content-sm-center">
        <div
            class="table-responsive"
        >
            <table
                class="table table-primary"
            >
               
                <tbody>
                    <tr class="">
                        <td scope="row">R1C1</td>
                        <td>R1C2</td>
                        <td>R1C3</td>
                    </tr>
                    <tr class="">
                        <td scope="row">Item</td>
                        <td>Item</td>
                        <td>Item</td>
                    </tr>
                </tbody>
            </table>
        </div>
                    
      </div>
    </div>
  </div>
      </div>
    </div>
  )
}
