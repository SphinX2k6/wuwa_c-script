using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000985 RID: 2437
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveVector")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UCurveVector : UCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060089C5 RID: 35269 RVA: 0x000C562B File Offset: 0x000C382B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveVector._ClassPtr;
		}

		// Token: 0x060089C6 RID: 35270 RVA: 0x000C5638 File Offset: 0x000C3838
		public UCurveVector() : this(BuiltinUtils.AllocNativeUObject(UCurveVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060089C7 RID: 35271 RVA: 0x000C5660 File Offset: 0x000C3860
		public UCurveVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCurveVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x060089C8 RID: 35272 RVA: 0x000C5694 File Offset: 0x000C3894
		// (set) Token: 0x060089C9 RID: 35273 RVA: 0x000C56CE File Offset: 0x000C38CE
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

		// Token: 0x060089CA RID: 35274 RVA: 0x000C56DC File Offset: 0x000C38DC
		public FVector GetVectorValue(float InTime)
		{
			return UCurveVector.__GetVectorValue_Internal(base.NativePtr, InTime);
		}

		// Token: 0x060089CB RID: 35275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorValue_Internal(IntPtr @this, float InTime);

		// Token: 0x060089CC RID: 35276 RVA: 0x000C56EA File Offset: 0x000C38EA
		static UCurveVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveVector");
		}

		// Token: 0x060089CD RID: 35277 RVA: 0x000C56F8 File Offset: 0x000C38F8
		protected UCurveVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400416B RID: 16747
		public new const string __ObjectPath = "/Script/Engine.CurveVector";

		// Token: 0x0400416C RID: 16748
		private static IntPtr _ClassPtr;

		// Token: 0x0400416D RID: 16749
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400416E RID: 16750
		internal static int __PropertyOffset_FloatCurves;

		// Token: 0x0400416F RID: 16751
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FRichCurve> _FloatCurves;
	}
}
