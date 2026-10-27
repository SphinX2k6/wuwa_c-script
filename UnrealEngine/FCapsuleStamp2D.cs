using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A53 RID: 6739
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CapsuleStamp2D")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FCapsuleStamp2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018E6B RID: 101995 RVA: 0x0024D068 File Offset: 0x0024B268
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCapsuleStamp2D._ScriptStructPtr != 0) ? FCapsuleStamp2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CapsuleStamp2D", ref FCapsuleStamp2D._ScriptStructPtr);
		}

		// Token: 0x17006292 RID: 25234
		// (get) Token: 0x06018E6C RID: 101996 RVA: 0x0024D08C File Offset: 0x0024B28C
		// (set) Token: 0x06018E6D RID: 101997 RVA: 0x0024D0A0 File Offset: 0x0024B2A0
		public unsafe FVector2D CenterUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_CenterUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_CenterUV) = value;
			}
		}

		// Token: 0x17006293 RID: 25235
		// (get) Token: 0x06018E6E RID: 101998 RVA: 0x0024D0B5 File Offset: 0x0024B2B5
		// (set) Token: 0x06018E6F RID: 101999 RVA: 0x0024D0C9 File Offset: 0x0024B2C9
		public unsafe FVector2D Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x17006294 RID: 25236
		// (get) Token: 0x06018E70 RID: 102000 RVA: 0x0024D0DE File Offset: 0x0024B2DE
		// (set) Token: 0x06018E71 RID: 102001 RVA: 0x0024D0EE File Offset: 0x0024B2EE
		public unsafe float HalfLengthUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_HalfLengthUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_HalfLengthUV) = value;
			}
		}

		// Token: 0x17006295 RID: 25237
		// (get) Token: 0x06018E72 RID: 102002 RVA: 0x0024D0FF File Offset: 0x0024B2FF
		// (set) Token: 0x06018E73 RID: 102003 RVA: 0x0024D10F File Offset: 0x0024B30F
		public unsafe float RadiusUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_RadiusUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_RadiusUV) = value;
			}
		}

		// Token: 0x17006296 RID: 25238
		// (get) Token: 0x06018E74 RID: 102004 RVA: 0x0024D120 File Offset: 0x0024B320
		// (set) Token: 0x06018E75 RID: 102005 RVA: 0x0024D130 File Offset: 0x0024B330
		public unsafe float SoftEdgeWidthUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_SoftEdgeWidthUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_SoftEdgeWidthUV) = value;
			}
		}

		// Token: 0x17006297 RID: 25239
		// (get) Token: 0x06018E76 RID: 102006 RVA: 0x0024D141 File Offset: 0x0024B341
		// (set) Token: 0x06018E77 RID: 102007 RVA: 0x0024D151 File Offset: 0x0024B351
		public unsafe bool bUseEndValues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_bUseEndValues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_bUseEndValues) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006298 RID: 25240
		// (get) Token: 0x06018E78 RID: 102008 RVA: 0x0024D162 File Offset: 0x0024B362
		// (set) Token: 0x06018E79 RID: 102009 RVA: 0x0024D172 File Offset: 0x0024B372
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17006299 RID: 25241
		// (get) Token: 0x06018E7A RID: 102010 RVA: 0x0024D183 File Offset: 0x0024B383
		// (set) Token: 0x06018E7B RID: 102011 RVA: 0x0024D193 File Offset: 0x0024B393
		public unsafe float ValueA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_ValueA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_ValueA) = value;
			}
		}

		// Token: 0x1700629A RID: 25242
		// (get) Token: 0x06018E7C RID: 102012 RVA: 0x0024D1A4 File Offset: 0x0024B3A4
		// (set) Token: 0x06018E7D RID: 102013 RVA: 0x0024D1B4 File Offset: 0x0024B3B4
		public unsafe float ValueB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_ValueB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStamp2D.__PropertyOffset_ValueB) = value;
			}
		}

		// Token: 0x06018E7E RID: 102014 RVA: 0x0024D1C5 File Offset: 0x0024B3C5
		public FCapsuleStamp2D()
		{
		}

		// Token: 0x06018E7F RID: 102015 RVA: 0x0024D1D0 File Offset: 0x0024B3D0
		public FCapsuleStamp2D(FVector2D CenterUV, FVector2D Axis, float HalfLengthUV, float RadiusUV, float SoftEdgeWidthUV, bool bUseEndValues, float Value, float ValueA, float ValueB)
		{
			this.CenterUV = CenterUV;
			this.Axis = Axis;
			this.HalfLengthUV = HalfLengthUV;
			this.RadiusUV = RadiusUV;
			this.SoftEdgeWidthUV = SoftEdgeWidthUV;
			this.bUseEndValues = bUseEndValues;
			this.Value = Value;
			this.ValueA = ValueA;
			this.ValueB = ValueB;
		}

		// Token: 0x06018E80 RID: 102016 RVA: 0x0024D228 File Offset: 0x0024B428
		protected override IntPtr GetUStructPtr()
		{
			return FCapsuleStamp2D.StaticStruct();
		}

		// Token: 0x06018E81 RID: 102017 RVA: 0x0024D234 File Offset: 0x0024B434
		[NullableContext(2)]
		public FCapsuleStamp2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018E82 RID: 102018 RVA: 0x0024D23E File Offset: 0x0024B43E
		public FCapsuleStamp2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018E83 RID: 102019 RVA: 0x0024D249 File Offset: 0x0024B449
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCapsuleStamp2D(Pointer, false, true);
		}

		// Token: 0x06018E84 RID: 102020 RVA: 0x0024D253 File Offset: 0x0024B453
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCapsuleStamp2D(Pointer, MemoryOwner);
		}

		// Token: 0x0400D798 RID: 55192
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CapsuleStamp2D";

		// Token: 0x0400D799 RID: 55193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D79A RID: 55194
		internal static int __PropertyOffset_CenterUV;

		// Token: 0x0400D79B RID: 55195
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400D79C RID: 55196
		internal static int __PropertyOffset_HalfLengthUV;

		// Token: 0x0400D79D RID: 55197
		internal static int __PropertyOffset_RadiusUV;

		// Token: 0x0400D79E RID: 55198
		internal static int __PropertyOffset_SoftEdgeWidthUV;

		// Token: 0x0400D79F RID: 55199
		internal static int __PropertyOffset_bUseEndValues;

		// Token: 0x0400D7A0 RID: 55200
		internal static int __PropertyOffset_Value;

		// Token: 0x0400D7A1 RID: 55201
		internal static int __PropertyOffset_ValueA;

		// Token: 0x0400D7A2 RID: 55202
		internal static int __PropertyOffset_ValueB;
	}
}
