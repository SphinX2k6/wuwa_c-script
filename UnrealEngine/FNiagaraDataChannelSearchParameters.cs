using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002554 RID: 9556
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelSearchParameters")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNiagaraDataChannelSearchParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602380E RID: 145422 RVA: 0x00347BED File Offset: 0x00345DED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataChannelSearchParameters._ScriptStructPtr != 0) ? FNiagaraDataChannelSearchParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDataChannelSearchParameters", ref FNiagaraDataChannelSearchParameters._ScriptStructPtr);
		}

		// Token: 0x1700884D RID: 34893
		// (get) Token: 0x0602380F RID: 145423 RVA: 0x00347C11 File Offset: 0x00345E11
		// (set) Token: 0x06023810 RID: 145424 RVA: 0x00347C25 File Offset: 0x00345E25
		[Nullable(2)]
		public unsafe USceneComponent OwningComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraDataChannelSearchParameters.__PropertyOffset_OwningComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraDataChannelSearchParameters.__PropertyOffset_OwningComponent, value);
			}
		}

		// Token: 0x1700884E RID: 34894
		// (get) Token: 0x06023811 RID: 145425 RVA: 0x00347C3A File Offset: 0x00345E3A
		// (set) Token: 0x06023812 RID: 145426 RVA: 0x00347C4E File Offset: 0x00345E4E
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataChannelSearchParameters.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataChannelSearchParameters.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700884F RID: 34895
		// (get) Token: 0x06023813 RID: 145427 RVA: 0x00347C63 File Offset: 0x00345E63
		// (set) Token: 0x06023814 RID: 145428 RVA: 0x00347C7C File Offset: 0x00345E7C
		public unsafe bool bOverrideLocation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraDataChannelSearchParameters.__PropertyOffset_bOverrideLocation) & FNiagaraDataChannelSearchParameters.__PropertyMask_bOverrideLocation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraDataChannelSearchParameters.__PropertyOffset_bOverrideLocation) = ((*(base.NativePtr + (IntPtr)FNiagaraDataChannelSearchParameters.__PropertyOffset_bOverrideLocation) & ~FNiagaraDataChannelSearchParameters.__PropertyMask_bOverrideLocation) | (value ? FNiagaraDataChannelSearchParameters.__PropertyMask_bOverrideLocation : 0));
			}
		}

		// Token: 0x06023815 RID: 145429 RVA: 0x00347CAC File Offset: 0x00345EAC
		public FNiagaraDataChannelSearchParameters()
		{
		}

		// Token: 0x06023816 RID: 145430 RVA: 0x00347CB4 File Offset: 0x00345EB4
		[NullableContext(1)]
		public FNiagaraDataChannelSearchParameters(USceneComponent OwningComponent, FVector Location, bool bOverrideLocation)
		{
			this.OwningComponent = OwningComponent;
			this.Location = Location;
			this.bOverrideLocation = bOverrideLocation;
		}

		// Token: 0x06023817 RID: 145431 RVA: 0x00347CD1 File Offset: 0x00345ED1
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataChannelSearchParameters.StaticStruct();
		}

		// Token: 0x06023818 RID: 145432 RVA: 0x00347CDD File Offset: 0x00345EDD
		[NullableContext(2)]
		public FNiagaraDataChannelSearchParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023819 RID: 145433 RVA: 0x00347CE7 File Offset: 0x00345EE7
		public FNiagaraDataChannelSearchParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602381A RID: 145434 RVA: 0x00347CF2 File Offset: 0x00345EF2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataChannelSearchParameters(Pointer, false, true);
		}

		// Token: 0x0602381B RID: 145435 RVA: 0x00347CFC File Offset: 0x00345EFC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataChannelSearchParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0401308A RID: 77962
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelSearchParameters";

		// Token: 0x0401308B RID: 77963
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401308C RID: 77964
		internal static int __PropertyOffset_OwningComponent;

		// Token: 0x0401308D RID: 77965
		internal static int __PropertyOffset_Location;

		// Token: 0x0401308E RID: 77966
		internal static int __PropertyOffset_bOverrideLocation;

		// Token: 0x0401308F RID: 77967
		internal static byte __PropertyMask_bOverrideLocation;
	}
}
