using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002588 RID: 9608
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceSplineLUT")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNiagaraDataInterfaceSplineLUT : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023A85 RID: 146053 RVA: 0x0034B7C9 File Offset: 0x003499C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataInterfaceSplineLUT._ScriptStructPtr != 0) ? FNiagaraDataInterfaceSplineLUT._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDataInterfaceSplineLUT", ref FNiagaraDataInterfaceSplineLUT._ScriptStructPtr);
		}

		// Token: 0x170088E0 RID: 35040
		// (get) Token: 0x06023A86 RID: 146054 RVA: 0x0034B7F0 File Offset: 0x003499F0
		// (set) Token: 0x06023A87 RID: 146055 RVA: 0x0034B833 File Offset: 0x00349A33
		public TArray<FVector> Positions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Positions) == null)
				{
					result = (this._Positions = new TArray<FVector>(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_Positions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Positions.CopyAssign(value);
			}
		}

		// Token: 0x170088E1 RID: 35041
		// (get) Token: 0x06023A88 RID: 146056 RVA: 0x0034B844 File Offset: 0x00349A44
		// (set) Token: 0x06023A89 RID: 146057 RVA: 0x0034B887 File Offset: 0x00349A87
		public TArray<FVector> Scales
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Scales) == null)
				{
					result = (this._Scales = new TArray<FVector>(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_Scales, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Scales.CopyAssign(value);
			}
		}

		// Token: 0x170088E2 RID: 35042
		// (get) Token: 0x06023A8A RID: 146058 RVA: 0x0034B898 File Offset: 0x00349A98
		// (set) Token: 0x06023A8B RID: 146059 RVA: 0x0034B8DB File Offset: 0x00349ADB
		public TArray<FQuat> Rotations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._Rotations) == null)
				{
					result = (this._Rotations = new TArray<FQuat>(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_Rotations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotations.CopyAssign(value);
			}
		}

		// Token: 0x170088E3 RID: 35043
		// (get) Token: 0x06023A8C RID: 146060 RVA: 0x0034B8E9 File Offset: 0x00349AE9
		// (set) Token: 0x06023A8D RID: 146061 RVA: 0x0034B8F9 File Offset: 0x00349AF9
		public unsafe float SplineLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_SplineLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_SplineLength) = value;
			}
		}

		// Token: 0x170088E4 RID: 35044
		// (get) Token: 0x06023A8E RID: 146062 RVA: 0x0034B90A File Offset: 0x00349B0A
		// (set) Token: 0x06023A8F RID: 146063 RVA: 0x0034B91A File Offset: 0x00349B1A
		public unsafe float SplineDistanceStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_SplineDistanceStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_SplineDistanceStep) = value;
			}
		}

		// Token: 0x170088E5 RID: 35045
		// (get) Token: 0x06023A90 RID: 146064 RVA: 0x0034B92B File Offset: 0x00349B2B
		// (set) Token: 0x06023A91 RID: 146065 RVA: 0x0034B93B File Offset: 0x00349B3B
		public unsafe float InvSplineDistanceStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_InvSplineDistanceStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_InvSplineDistanceStep) = value;
			}
		}

		// Token: 0x170088E6 RID: 35046
		// (get) Token: 0x06023A92 RID: 146066 RVA: 0x0034B94C File Offset: 0x00349B4C
		// (set) Token: 0x06023A93 RID: 146067 RVA: 0x0034B95C File Offset: 0x00349B5C
		public unsafe int MaxIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_MaxIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataInterfaceSplineLUT.__PropertyOffset_MaxIndex) = value;
			}
		}

		// Token: 0x06023A94 RID: 146068 RVA: 0x0034B96D File Offset: 0x00349B6D
		public FNiagaraDataInterfaceSplineLUT()
		{
		}

		// Token: 0x06023A95 RID: 146069 RVA: 0x0034B975 File Offset: 0x00349B75
		public FNiagaraDataInterfaceSplineLUT(TArray<FVector> Positions, TArray<FVector> Scales, TArray<FQuat> Rotations, float SplineLength, float SplineDistanceStep, float InvSplineDistanceStep, int MaxIndex)
		{
			this.Positions = Positions;
			this.Scales = Scales;
			this.Rotations = Rotations;
			this.SplineLength = SplineLength;
			this.SplineDistanceStep = SplineDistanceStep;
			this.InvSplineDistanceStep = InvSplineDistanceStep;
			this.MaxIndex = MaxIndex;
		}

		// Token: 0x06023A96 RID: 146070 RVA: 0x0034B9B2 File Offset: 0x00349BB2
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataInterfaceSplineLUT.StaticStruct();
		}

		// Token: 0x06023A97 RID: 146071 RVA: 0x0034B9BE File Offset: 0x00349BBE
		[NullableContext(2)]
		public FNiagaraDataInterfaceSplineLUT(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023A98 RID: 146072 RVA: 0x0034B9C8 File Offset: 0x00349BC8
		public FNiagaraDataInterfaceSplineLUT(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023A99 RID: 146073 RVA: 0x0034B9D3 File Offset: 0x00349BD3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataInterfaceSplineLUT(Pointer, false, true);
		}

		// Token: 0x06023A9A RID: 146074 RVA: 0x0034B9DD File Offset: 0x00349BDD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataInterfaceSplineLUT(Pointer, MemoryOwner);
		}

		// Token: 0x040131E9 RID: 78313
		public const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceSplineLUT";

		// Token: 0x040131EA RID: 78314
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040131EB RID: 78315
		internal static int __PropertyOffset_Positions;

		// Token: 0x040131EC RID: 78316
		[Nullable(2)]
		private TArray<FVector> _Positions;

		// Token: 0x040131ED RID: 78317
		internal static int __PropertyOffset_Scales;

		// Token: 0x040131EE RID: 78318
		[Nullable(2)]
		private TArray<FVector> _Scales;

		// Token: 0x040131EF RID: 78319
		internal static int __PropertyOffset_Rotations;

		// Token: 0x040131F0 RID: 78320
		[Nullable(2)]
		private TArray<FQuat> _Rotations;

		// Token: 0x040131F1 RID: 78321
		internal static int __PropertyOffset_SplineLength;

		// Token: 0x040131F2 RID: 78322
		internal static int __PropertyOffset_SplineDistanceStep;

		// Token: 0x040131F3 RID: 78323
		internal static int __PropertyOffset_InvSplineDistanceStep;

		// Token: 0x040131F4 RID: 78324
		internal static int __PropertyOffset_MaxIndex;
	}
}
