using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025DE RID: 9694
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptDataInterfaceInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FNiagaraScriptDataInterfaceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024095 RID: 147605 RVA: 0x00355208 File Offset: 0x00353408
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScriptDataInterfaceInfo._ScriptStructPtr != 0) ? FNiagaraScriptDataInterfaceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScriptDataInterfaceInfo", ref FNiagaraScriptDataInterfaceInfo._ScriptStructPtr);
		}

		// Token: 0x17008AA7 RID: 35495
		// (get) Token: 0x06024096 RID: 147606 RVA: 0x0035522C File Offset: 0x0035342C
		// (set) Token: 0x06024097 RID: 147607 RVA: 0x00355240 File Offset: 0x00353440
		[Nullable(2)]
		public unsafe UNiagaraDataInterface DataInterface
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraScriptDataInterfaceInfo.__PropertyOffset_DataInterface);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraScriptDataInterfaceInfo.__PropertyOffset_DataInterface, value);
			}
		}

		// Token: 0x17008AA8 RID: 35496
		// (get) Token: 0x06024098 RID: 147608 RVA: 0x00355255 File Offset: 0x00353455
		// (set) Token: 0x06024099 RID: 147609 RVA: 0x00355269 File Offset: 0x00353469
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008AA9 RID: 35497
		// (get) Token: 0x0602409A RID: 147610 RVA: 0x0035527E File Offset: 0x0035347E
		// (set) Token: 0x0602409B RID: 147611 RVA: 0x0035528E File Offset: 0x0035348E
		public unsafe int UserPtrIdx
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_UserPtrIdx);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_UserPtrIdx) = value;
			}
		}

		// Token: 0x17008AAA RID: 35498
		// (get) Token: 0x0602409C RID: 147612 RVA: 0x003552A0 File Offset: 0x003534A0
		// (set) Token: 0x0602409D RID: 147613 RVA: 0x003552E3 File Offset: 0x003534E3
		public FNiagaraTypeDefinition Type
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTypeDefinition result;
				if ((result = this._Type) == null)
				{
					result = (this._Type = new FNiagaraTypeDefinition(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_Type, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTypeDefinition.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_Type, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008AAB RID: 35499
		// (get) Token: 0x0602409E RID: 147614 RVA: 0x00355304 File Offset: 0x00353504
		// (set) Token: 0x0602409F RID: 147615 RVA: 0x00355318 File Offset: 0x00353518
		public unsafe FName RegisteredParameterMapRead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_RegisteredParameterMapRead);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_RegisteredParameterMapRead) = value;
			}
		}

		// Token: 0x17008AAC RID: 35500
		// (get) Token: 0x060240A0 RID: 147616 RVA: 0x0035532D File Offset: 0x0035352D
		// (set) Token: 0x060240A1 RID: 147617 RVA: 0x00355341 File Offset: 0x00353541
		public unsafe FName RegisteredParameterMapWrite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_RegisteredParameterMapWrite);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptDataInterfaceInfo.__PropertyOffset_RegisteredParameterMapWrite) = value;
			}
		}

		// Token: 0x060240A2 RID: 147618 RVA: 0x00355356 File Offset: 0x00353556
		public FNiagaraScriptDataInterfaceInfo()
		{
		}

		// Token: 0x060240A3 RID: 147619 RVA: 0x0035535E File Offset: 0x0035355E
		public FNiagaraScriptDataInterfaceInfo(UNiagaraDataInterface DataInterface, FName Name, int UserPtrIdx, FNiagaraTypeDefinition Type, FName RegisteredParameterMapRead, FName RegisteredParameterMapWrite)
		{
			this.DataInterface = DataInterface;
			this.Name = Name;
			this.UserPtrIdx = UserPtrIdx;
			this.Type = Type;
			this.RegisteredParameterMapRead = RegisteredParameterMapRead;
			this.RegisteredParameterMapWrite = RegisteredParameterMapWrite;
		}

		// Token: 0x060240A4 RID: 147620 RVA: 0x00355393 File Offset: 0x00353593
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScriptDataInterfaceInfo.StaticStruct();
		}

		// Token: 0x060240A5 RID: 147621 RVA: 0x0035539F File Offset: 0x0035359F
		[NullableContext(2)]
		public FNiagaraScriptDataInterfaceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060240A6 RID: 147622 RVA: 0x003553A9 File Offset: 0x003535A9
		public FNiagaraScriptDataInterfaceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060240A7 RID: 147623 RVA: 0x003553B4 File Offset: 0x003535B4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScriptDataInterfaceInfo(Pointer, false, true);
		}

		// Token: 0x060240A8 RID: 147624 RVA: 0x003553BE File Offset: 0x003535BE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScriptDataInterfaceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401353E RID: 79166
		public const string __ObjectPath = "/Script/Niagara.NiagaraScriptDataInterfaceInfo";

		// Token: 0x0401353F RID: 79167
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013540 RID: 79168
		internal static int __PropertyOffset_DataInterface;

		// Token: 0x04013541 RID: 79169
		internal static int __PropertyOffset_Name;

		// Token: 0x04013542 RID: 79170
		internal static int __PropertyOffset_UserPtrIdx;

		// Token: 0x04013543 RID: 79171
		internal static int __PropertyOffset_Type;

		// Token: 0x04013544 RID: 79172
		[Nullable(2)]
		private FNiagaraTypeDefinition _Type;

		// Token: 0x04013545 RID: 79173
		internal static int __PropertyOffset_RegisteredParameterMapRead;

		// Token: 0x04013546 RID: 79174
		internal static int __PropertyOffset_RegisteredParameterMapWrite;
	}
}
