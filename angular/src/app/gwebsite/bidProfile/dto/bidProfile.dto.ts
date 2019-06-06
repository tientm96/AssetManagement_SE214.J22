import { ComboboxItemDto } from '@shared/service-proxies/service-proxies';

export class BidProfileDto {
    id: number;
    name: string;
    alias: string;
    description: string;
    parentId: number | null;
    displayOrder: number | null;
    homeOrder: number | null;
    image: string;
    homeFlag: boolean | null;
    metaKeyword: string;
    metaDescription: string;
}

export class GetBidProfileOutput {
    bidProfile: BidProfileDto;
    bidProfiles: ComboboxItemDto[];
}

export enum ApprovalStatusEnum {
    Active = 1,
    Inactive = 2,
    Close = 3
}

export enum StatusEnum {
    Open = 1,
    Close = 2,
    All = 3
}

export class NewPJDto {
    code: string;
    name: string;
    bidProfileTypeId: number;
    supplierId: number;
    unitPrice: string;
    calUnit: string;
    description: string;
    status: number;

    constructor(code: string, name: string, bidProfileTypeId: number, supplierId: number,
        unitPrice: string, calUnit: string, description: string, status: number) {
        this.code = code;
        this.name = name;
        this.bidProfileTypeId = bidProfileTypeId;
        this.supplierId = supplierId;
        this.unitPrice = unitPrice;
        this.calUnit = calUnit;
        this.description = description;
        this.status = status;
    }
}

export class BidProfileTypeInfo {
    id: number;
    info: string;
    constructor(id: number, info: string) {
        this.id = id;
        this.info = info;
    }
}
