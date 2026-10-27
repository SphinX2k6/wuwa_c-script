using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C6D RID: 3181
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.IntegralCurve")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FIntegralCurve : FIndexedCurve, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A1D5 RID: 41429 RVA: 0x000E5DC0 File Offset: 0x000E3FC0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntegralCurve._ScriptStructPtr != 0) ? FIntegralCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.IntegralCurve", ref FIntegralCurve._ScriptStructPtr);
		}

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x0600A1D6 RID: 41430 RVA: 0x000E5DE4 File Offset: 0x000E3FE4
		// (set) Token: 0x0600A1D7 RID: 41431 RVA: 0x000E5E27 File Offset: 0x000E4027
		public TArray<FIntegralKey> Keys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIntegralKey> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<FIntegralKey>(base.NativePtr + (IntPtr)FIntegralCurve.__PropertyOffset_Keys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x0600A1D8 RID: 41432 RVA: 0x000E5E35 File Offset: 0x000E4035
		// (set) Token: 0x0600A1D9 RID: 41433 RVA: 0x000E5E45 File Offset: 0x000E4045
		public unsafe int DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIntegralCurve.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIntegralCurve.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x0600A1DA RID: 41434 RVA: 0x000E5E56 File Offset: 0x000E4056
		// (set) Token: 0x0600A1DB RID: 41435 RVA: 0x000E5E66 File Offset: 0x000E4066
		public unsafe bool bUseDefaultValueBeforeFirstKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIntegralCurve.__PropertyOffset_bUseDefaultValueBeforeFirstKey) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIntegralCurve.__PropertyOffset_bUseDefaultValueBeforeFirstKey) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x000E5E77 File Offset: 0x000E4077
		public FIntegralCurve()
		{
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x000E5E7F File Offset: 0x000E407F
		public FIntegralCurve(TArray<FIntegralKey> Keys, int DefaultValue, bool bUseDefaultValueBeforeFirstKey, FKeyHandleMap KeyHandlesToIndices)
		{
			this.Keys = Keys;
			this.DefaultValue = DefaultValue;
			this.bUseDefaultValueBeforeFirstKey = bUseDefaultValueBeforeFirstKey;
			base.KeyHandlesToIndices = KeyHandlesToIndices;
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x000E5EA4 File Offset: 0x000E40A4
		protected override IntPtr GetUStructPtr()
		{
			return FIntegralCurve.StaticStruct();
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x000E5EB0 File Offset: 0x000E40B0
		[NullableContext(2)]
		public FIntegralCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x000E5EBA File Offset: 0x000E40BA
		public FIntegralCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x000E5EC5 File Offset: 0x000E40C5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIntegralCurve(Pointer, false, true);
		}

		// Token: 0x0600A1E2 RID: 41442 RVA: 0x000E5ECF File Offset: 0x000E40CF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIntegralCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040058D3 RID: 22739
		public new const string __ObjectPath = "/Script/Engine.IntegralCurve";

		// Token: 0x040058D4 RID: 22740
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058D5 RID: 22741
		internal static int __PropertyOffset_Keys;

		// Token: 0x040058D6 RID: 22742
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FIntegralKey> _Keys;

		// Token: 0x040058D7 RID: 22743
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040058D8 RID: 22744
		internal static int __PropertyOffset_bUseDefaultValueBeforeFirstKey;
	}
}
