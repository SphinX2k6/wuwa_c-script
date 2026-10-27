using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E71 RID: 3697
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVectorNoise")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMaterialExpressionVectorNoise : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5AE RID: 50606 RVA: 0x0011E46A File Offset: 0x0011C66A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVectorNoise._ClassPtr;
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x0011E478 File Offset: 0x0011C678
		public UMaterialExpressionVectorNoise() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVectorNoise.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5B0 RID: 50608 RVA: 0x0011E4A0 File Offset: 0x0011C6A0
		[NullableContext(1)]
		public UMaterialExpressionVectorNoise(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVectorNoise.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0600C5B1 RID: 50609 RVA: 0x0011E4D4 File Offset: 0x0011C6D4
		// (set) Token: 0x0600C5B2 RID: 50610 RVA: 0x0011E50D File Offset: 0x0011C70D
		[Nullable(1)]
		public FExpressionInput Position
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_Position, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0600C5B3 RID: 50611 RVA: 0x0011E52E File Offset: 0x0011C72E
		// (set) Token: 0x0600C5B4 RID: 50612 RVA: 0x0011E542 File Offset: 0x0011C742
		public unsafe TEnumAsByte<EVectorNoiseFunction> NoiseFunction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_NoiseFunction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_NoiseFunction) = value;
			}
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0600C5B5 RID: 50613 RVA: 0x0011E557 File Offset: 0x0011C757
		// (set) Token: 0x0600C5B6 RID: 50614 RVA: 0x0011E567 File Offset: 0x0011C767
		public unsafe int Quality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_Quality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_Quality) = value;
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0600C5B7 RID: 50615 RVA: 0x0011E578 File Offset: 0x0011C778
		// (set) Token: 0x0600C5B8 RID: 50616 RVA: 0x0011E591 File Offset: 0x0011C791
		public unsafe bool bTiling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_bTiling) & UMaterialExpressionVectorNoise.__PropertyMask_bTiling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_bTiling) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_bTiling) & ~UMaterialExpressionVectorNoise.__PropertyMask_bTiling) | (value ? UMaterialExpressionVectorNoise.__PropertyMask_bTiling : 0));
			}
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0600C5B9 RID: 50617 RVA: 0x0011E5C1 File Offset: 0x0011C7C1
		// (set) Token: 0x0600C5BA RID: 50618 RVA: 0x0011E5D1 File Offset: 0x0011C7D1
		public unsafe uint TileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_TileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVectorNoise.__PropertyOffset_TileSize) = (int)value;
			}
		}

		// Token: 0x0600C5BB RID: 50619 RVA: 0x0011E5E2 File Offset: 0x0011C7E2
		static UMaterialExpressionVectorNoise()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVectorNoise");
		}

		// Token: 0x0600C5BC RID: 50620 RVA: 0x0011E5F0 File Offset: 0x0011C7F0
		protected UMaterialExpressionVectorNoise(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069C2 RID: 27074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVectorNoise";

		// Token: 0x040069C3 RID: 27075
		private static IntPtr _ClassPtr;

		// Token: 0x040069C4 RID: 27076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069C5 RID: 27077
		internal static int __PropertyOffset_Position;

		// Token: 0x040069C6 RID: 27078
		[Nullable(2)]
		private FExpressionInput _Position;

		// Token: 0x040069C7 RID: 27079
		internal static int __PropertyOffset_NoiseFunction;

		// Token: 0x040069C8 RID: 27080
		internal static int __PropertyOffset_Quality;

		// Token: 0x040069C9 RID: 27081
		internal static int __PropertyOffset_bTiling;

		// Token: 0x040069CA RID: 27082
		internal static byte __PropertyMask_bTiling;

		// Token: 0x040069CB RID: 27083
		internal static int __PropertyOffset_TileSize;
	}
}
