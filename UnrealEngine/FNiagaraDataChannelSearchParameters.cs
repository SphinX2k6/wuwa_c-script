using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A4 RID: 1956
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelSearchParameters")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNiagaraDataChannelSearchParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A9F8 RID: 43512 RVA: 0x000FAD36 File Offset: 0x000F8F36
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataChannelSearchParameters._ScriptStructPtr != 0) ? FNiagaraDataChannelSearchParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDataChannelSearchParameters", ref FNiagaraDataChannelSearchParameters._ScriptStructPtr);
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x0600A9F9 RID: 43513 RVA: 0x000FAD5A File Offset: 0x000F8F5A
		// (set) Token: 0x0600A9FA RID: 43514 RVA: 0x000FAD6E File Offset: 0x000F8F6E
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

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x0600A9FB RID: 43515 RVA: 0x000FAD83 File Offset: 0x000F8F83
		// (set) Token: 0x0600A9FC RID: 43516 RVA: 0x000FAD97 File Offset: 0x000F8F97
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

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x0600A9FD RID: 43517 RVA: 0x000FADAC File Offset: 0x000F8FAC
		// (set) Token: 0x0600A9FE RID: 43518 RVA: 0x000FADC5 File Offset: 0x000F8FC5
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

		// Token: 0x0600A9FF RID: 43519 RVA: 0x000FADF5 File Offset: 0x000F8FF5
		public FNiagaraDataChannelSearchParameters()
		{
		}

		// Token: 0x0600AA00 RID: 43520 RVA: 0x000FADFD File Offset: 0x000F8FFD
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataChannelSearchParameters.StaticStruct();
		}

		// Token: 0x0600AA01 RID: 43521 RVA: 0x000FAE09 File Offset: 0x000F9009
		[NullableContext(2)]
		public FNiagaraDataChannelSearchParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AA02 RID: 43522 RVA: 0x000FAE13 File Offset: 0x000F9013
		public FNiagaraDataChannelSearchParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x000FAE1E File Offset: 0x000F901E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataChannelSearchParameters(Pointer, false, true);
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x000FAE28 File Offset: 0x000F9028
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataChannelSearchParameters(Pointer, MemoryOwner);
		}

		// Token: 0x040048DF RID: 18655
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelSearchParameters";

		// Token: 0x040048E0 RID: 18656
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040048E1 RID: 18657
		internal static int __PropertyOffset_OwningComponent;

		// Token: 0x040048E2 RID: 18658
		internal static int __PropertyOffset_Location;

		// Token: 0x040048E3 RID: 18659
		internal static int __PropertyOffset_bOverrideLocation;

		// Token: 0x040048E4 RID: 18660
		internal static byte __PropertyMask_bOverrideLocation;
	}
}
