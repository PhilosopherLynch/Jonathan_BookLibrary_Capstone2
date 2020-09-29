import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Ibook } from '../interfaces/ibook';
import { BookComponent } from '../book/book.component';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  public async getBook(): Promise<Ibook[]> {
    return this.httpClient.get<Ibook[]>(`${this.baseUrl}book`).toPromise();
  }

  public async addBook(book: Ibook): Promise<Ibook> {
    return this.httpClient.post<Ibook>(`${this.baseUrl}book`, book).toPromise();
  }
}
