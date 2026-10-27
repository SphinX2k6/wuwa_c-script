using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002607 RID: 9735
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariant")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FNiagaraVariant : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602435A RID: 148314 RVA: 0x0035997A File Offset: 0x00357B7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariant._ScriptStructPtr != 0) ? FNiagaraVariant._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariant", ref FNiagaraVariant._ScriptStructPtr);
		}

		// Token: 0x17008B74 RID: 35700
		// (get) Token: 0x0602435B RID: 148315 RVA: 0x0035999E File Offset: 0x00357B9E
		// (set) Token: 0x0602435C RID: 148316 RVA: 0x003599B2 File Offset: 0x00357BB2
		public unsafe UObject Object
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraVariant.__PropertyOffset_Object);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraVariant.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x17008B75 RID: 35701
		// (get) Token: 0x0602435D RID: 148317 RVA: 0x003599C7 File Offset: 0x00357BC7
		// (set) Token: 0x0602435E RID: 148318 RVA: 0x003599DB File Offset: 0x00357BDB
		public unsafe UNiagaraDataInterface DataInterface
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraVariant.__PropertyOffset_DataInterface);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraVariant.__PropertyOffset_DataInterface, value);
			}
		}

		// Token: 0x17008B76 RID: 35702
		// (get) Token: 0x0602435F RID: 148319 RVA: 0x003599F0 File Offset: 0x00357BF0
		// (set) Token: 0x06024360 RID: 148320 RVA: 0x00359A33 File Offset: 0x00357C33
		[Nullable(1)]
		public TArray<byte> Bytes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Bytes) == null)
				{
					result = (this._Bytes = new TArray<byte>(base.NativePtr + (IntPtr)FNiagaraVariant.__PropertyOffset_Bytes, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Bytes.CopyAssign(value);
			}
		}

		// Token: 0x17008B77 RID: 35703
		// (get) Token: 0x06024361 RID: 148321 RVA: 0x00359A41 File Offset: 0x00357C41
		// (set) Token: 0x06024362 RID: 148322 RVA: 0x00359A51 File Offset: 0x00357C51
		public unsafe ENiagaraVariantMode CurrentMode
		{
			get
			{
				return (ENiagaraVariantMode)(*(base.NativePtr + (IntPtr)FNiagaraVariant.__PropertyOffset_CurrentMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariant.__PropertyOffset_CurrentMode) = (int)value;
			}
		}

		// Token: 0x06024363 RID: 148323 RVA: 0x00359A62 File Offset: 0x00357C62
		public FNiagaraVariant()
		{
		}

		// Token: 0x06024364 RID: 148324 RVA: 0x00359A6A File Offset: 0x00357C6A
		[NullableContext(1)]
		public FNiagaraVariant(UObject Object, UNiagaraDataInterface DataInterface, TArray<byte> Bytes, ENiagaraVariantMode CurrentMode)
		{
			this.Object = Object;
			this.DataInterface = DataInterface;
			this.Bytes = Bytes;
			this.CurrentMode = CurrentMode;
		}

		// Token: 0x06024365 RID: 148325 RVA: 0x00359A8F File Offset: 0x00357C8F
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariant.StaticStruct();
		}

		// Token: 0x06024366 RID: 148326 RVA: 0x00359A9B File Offset: 0x00357C9B
		public FNiagaraVariant(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024367 RID: 148327 RVA: 0x00359AA5 File Offset: 0x00357CA5
		public FNiagaraVariant(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024368 RID: 148328 RVA: 0x00359AB0 File Offset: 0x00357CB0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariant(Pointer, false, true);
		}

		// Token: 0x06024369 RID: 148329 RVA: 0x00359ABA File Offset: 0x00357CBA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariant(Pointer, MemoryOwner);
		}

		// Token: 0x040136D5 RID: 79573
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraVariant";

		// Token: 0x040136D6 RID: 79574
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136D7 RID: 79575
		internal static int __PropertyOffset_Object;

		// Token: 0x040136D8 RID: 79576
		internal static int __PropertyOffset_DataInterface;

		// Token: 0x040136D9 RID: 79577
		internal static int __PropertyOffset_Bytes;

		// Token: 0x040136DA RID: 79578
		private TArray<byte> _Bytes;

		// Token: 0x040136DB RID: 79579
		internal static int __PropertyOffset_CurrentMode;
	}
}
