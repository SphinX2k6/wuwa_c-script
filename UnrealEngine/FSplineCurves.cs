using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001178 RID: 4472
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SplineCurves")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FSplineCurves : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601069D RID: 67229 RVA: 0x00181CCE File Offset: 0x0017FECE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineCurves._ScriptStructPtr != 0) ? FSplineCurves._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SplineCurves", ref FSplineCurves._ScriptStructPtr);
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x0601069E RID: 67230 RVA: 0x00181CF4 File Offset: 0x0017FEF4
		// (set) Token: 0x0601069F RID: 67231 RVA: 0x00181D37 File Offset: 0x0017FF37
		public FInterpCurveVector Position
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FInterpCurveVector(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Position, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x060106A0 RID: 67232 RVA: 0x00181D58 File Offset: 0x0017FF58
		// (set) Token: 0x060106A1 RID: 67233 RVA: 0x00181D9B File Offset: 0x0017FF9B
		public FInterpCurveQuat Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveQuat result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FInterpCurveQuat(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Rotation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveQuat.StaticStruct(), base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x060106A2 RID: 67234 RVA: 0x00181DBC File Offset: 0x0017FFBC
		// (set) Token: 0x060106A3 RID: 67235 RVA: 0x00181DFF File Offset: 0x0017FFFF
		public FInterpCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FInterpCurveVector(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Scale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x060106A4 RID: 67236 RVA: 0x00181E20 File Offset: 0x00180020
		// (set) Token: 0x060106A5 RID: 67237 RVA: 0x00181E63 File Offset: 0x00180063
		public FInterpCurveFloat ReparamTable
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveFloat result;
				if ((result = this._ReparamTable) == null)
				{
					result = (this._ReparamTable = new FInterpCurveFloat(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_ReparamTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_ReparamTable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x060106A6 RID: 67238 RVA: 0x00181E84 File Offset: 0x00180084
		// (set) Token: 0x060106A7 RID: 67239 RVA: 0x00181E98 File Offset: 0x00180098
		[Nullable(2)]
		public unsafe USplineMetadata Metadata_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineMetadata>(base.NativePtr / (IntPtr)sizeof(void*) + FSplineCurves.__PropertyOffset_Metadata_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSplineCurves.__PropertyOffset_Metadata_DEPRECATED, value);
			}
		}

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x060106A8 RID: 67240 RVA: 0x00181EAD File Offset: 0x001800AD
		// (set) Token: 0x060106A9 RID: 67241 RVA: 0x00181EBD File Offset: 0x001800BD
		public unsafe uint Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Version) = (int)value;
			}
		}

		// Token: 0x060106AA RID: 67242 RVA: 0x00181ECE File Offset: 0x001800CE
		public FSplineCurves()
		{
		}

		// Token: 0x060106AB RID: 67243 RVA: 0x00181ED6 File Offset: 0x001800D6
		public FSplineCurves(FInterpCurveVector Position, FInterpCurveQuat Rotation, FInterpCurveVector Scale, FInterpCurveFloat ReparamTable, USplineMetadata Metadata_DEPRECATED, uint Version)
		{
			this.Position = Position;
			this.Rotation = Rotation;
			this.Scale = Scale;
			this.ReparamTable = ReparamTable;
			this.Metadata_DEPRECATED = Metadata_DEPRECATED;
			this.Version = Version;
		}

		// Token: 0x060106AC RID: 67244 RVA: 0x00181F0B File Offset: 0x0018010B
		protected override IntPtr GetUStructPtr()
		{
			return FSplineCurves.StaticStruct();
		}

		// Token: 0x060106AD RID: 67245 RVA: 0x00181F17 File Offset: 0x00180117
		[NullableContext(2)]
		public FSplineCurves(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060106AE RID: 67246 RVA: 0x00181F21 File Offset: 0x00180121
		public FSplineCurves(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060106AF RID: 67247 RVA: 0x00181F2C File Offset: 0x0018012C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineCurves(Pointer, false, true);
		}

		// Token: 0x060106B0 RID: 67248 RVA: 0x00181F36 File Offset: 0x00180136
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineCurves(Pointer, MemoryOwner);
		}

		// Token: 0x04008C97 RID: 35991
		public const string __ObjectPath = "/Script/Engine.SplineCurves";

		// Token: 0x04008C98 RID: 35992
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C99 RID: 35993
		internal static int __PropertyOffset_Position;

		// Token: 0x04008C9A RID: 35994
		[Nullable(2)]
		private FInterpCurveVector _Position;

		// Token: 0x04008C9B RID: 35995
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04008C9C RID: 35996
		[Nullable(2)]
		private FInterpCurveQuat _Rotation;

		// Token: 0x04008C9D RID: 35997
		internal static int __PropertyOffset_Scale;

		// Token: 0x04008C9E RID: 35998
		[Nullable(2)]
		private FInterpCurveVector _Scale;

		// Token: 0x04008C9F RID: 35999
		internal static int __PropertyOffset_ReparamTable;

		// Token: 0x04008CA0 RID: 36000
		[Nullable(2)]
		private FInterpCurveFloat _ReparamTable;

		// Token: 0x04008CA1 RID: 36001
		internal static int __PropertyOffset_Metadata_DEPRECATED;

		// Token: 0x04008CA2 RID: 36002
		internal static int __PropertyOffset_Version;
	}
}
