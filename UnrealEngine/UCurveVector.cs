using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C1 RID: 449
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveVector")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UCurveVector : UCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020E9 RID: 8425 RVA: 0x0003054C File Offset: 0x0002E74C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveVector._ClassPtr;
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00030558 File Offset: 0x0002E758
		public UCurveVector() : this(BuiltinUtils.AllocNativeUObject(UCurveVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00030580 File Offset: 0x0002E780
		public UCurveVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCurveVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x000305B4 File Offset: 0x0002E7B4
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x000305EE File Offset: 0x0002E7EE
		public TFixedArray<FRichCurve> FloatCurves
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FRichCurve> result;
				if ((result = this._FloatCurves) == null)
				{
					result = (this._FloatCurves = new TFixedArray<FRichCurve>(base.NativePtr + (IntPtr)UCurveVector.__PropertyOffset_FloatCurves, 3, this));
				}
				return result;
			}
			set
			{
				this.FloatCurves.CopyAssign(value);
			}
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000305FC File Offset: 0x0002E7FC
		public FVector GetVectorValue(float InTime)
		{
			return UCurveVector.__GetVectorValue_Internal(base.NativePtr, InTime);
		}

		// Token: 0x060020EF RID: 8431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorValue_Internal(IntPtr @this, float InTime);

		// Token: 0x060020F0 RID: 8432 RVA: 0x0003060A File Offset: 0x0002E80A
		static UCurveVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveVector");
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00030618 File Offset: 0x0002E818
		protected UCurveVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AEE RID: 2798
		public new const string __ObjectPath = "/Script/Engine.CurveVector";

		// Token: 0x04000AEF RID: 2799
		private static IntPtr _ClassPtr;

		// Token: 0x04000AF0 RID: 2800
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AF1 RID: 2801
		internal static int __PropertyOffset_FloatCurves;

		// Token: 0x04000AF2 RID: 2802
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FRichCurve> _FloatCurves;
	}
}
