using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200097D RID: 2429
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveFloat")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UCurveFloat : UCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008967 RID: 35175 RVA: 0x000C4D19 File Offset: 0x000C2F19
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveFloat._ClassPtr;
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x000C4D28 File Offset: 0x000C2F28
		public UCurveFloat() : this(BuiltinUtils.AllocNativeUObject(UCurveFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x000C4D50 File Offset: 0x000C2F50
		public UCurveFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCurveFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x0600896A RID: 35178 RVA: 0x000C4D84 File Offset: 0x000C2F84
		// (set) Token: 0x0600896B RID: 35179 RVA: 0x000C4DBD File Offset: 0x000C2FBD
		public FRichCurve FloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._FloatCurve) == null)
				{
					result = (this._FloatCurve = new FRichCurve(base.NativePtr + (IntPtr)UCurveFloat.__PropertyOffset_FloatCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UCurveFloat.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x0600896C RID: 35180 RVA: 0x000C4DDE File Offset: 0x000C2FDE
		// (set) Token: 0x0600896D RID: 35181 RVA: 0x000C4DEE File Offset: 0x000C2FEE
		public unsafe bool bIsEventCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveFloat.__PropertyOffset_bIsEventCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveFloat.__PropertyOffset_bIsEventCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x000C4DFF File Offset: 0x000C2FFF
		public float GetFloatValue(float InTime)
		{
			return UCurveFloat.__GetFloatValue_Internal(base.NativePtr, InTime);
		}

		// Token: 0x0600896F RID: 35183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatValue_Internal(IntPtr @this, float InTime);

		// Token: 0x06008970 RID: 35184 RVA: 0x000C4E0D File Offset: 0x000C300D
		static UCurveFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveFloat");
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x000C4E1B File Offset: 0x000C301B
		protected UCurveFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004141 RID: 16705
		public new const string __ObjectPath = "/Script/Engine.CurveFloat";

		// Token: 0x04004142 RID: 16706
		private static IntPtr _ClassPtr;

		// Token: 0x04004143 RID: 16707
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004144 RID: 16708
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x04004145 RID: 16709
		[Nullable(2)]
		private FRichCurve _FloatCurve;

		// Token: 0x04004146 RID: 16710
		internal static int __PropertyOffset_bIsEventCurve;
	}
}
