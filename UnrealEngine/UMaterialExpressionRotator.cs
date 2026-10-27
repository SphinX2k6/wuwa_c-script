using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E2B RID: 3627
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRotator")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMaterialExpressionRotator : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C301 RID: 49921 RVA: 0x0011965E File Offset: 0x0011785E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRotator._ClassPtr;
		}

		// Token: 0x0600C302 RID: 49922 RVA: 0x0011966C File Offset: 0x0011786C
		public UMaterialExpressionRotator() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRotator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x00119694 File Offset: 0x00117894
		public UMaterialExpressionRotator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRotator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0600C304 RID: 49924 RVA: 0x001196C8 File Offset: 0x001178C8
		// (set) Token: 0x0600C305 RID: 49925 RVA: 0x00119701 File Offset: 0x00117901
		public FExpressionInput Coordinate
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinate) == null)
				{
					result = (this._Coordinate = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_Coordinate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_Coordinate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0600C306 RID: 49926 RVA: 0x00119724 File Offset: 0x00117924
		// (set) Token: 0x0600C307 RID: 49927 RVA: 0x0011975D File Offset: 0x0011795D
		public FExpressionInput Time
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_Time, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x0600C308 RID: 49928 RVA: 0x0011977E File Offset: 0x0011797E
		// (set) Token: 0x0600C309 RID: 49929 RVA: 0x0011978E File Offset: 0x0011798E
		public unsafe float CenterX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_CenterX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_CenterX) = value;
			}
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0600C30A RID: 49930 RVA: 0x0011979F File Offset: 0x0011799F
		// (set) Token: 0x0600C30B RID: 49931 RVA: 0x001197AF File Offset: 0x001179AF
		public unsafe float CenterY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_CenterY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_CenterY) = value;
			}
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0600C30C RID: 49932 RVA: 0x001197C0 File Offset: 0x001179C0
		// (set) Token: 0x0600C30D RID: 49933 RVA: 0x001197D0 File Offset: 0x001179D0
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x0600C30E RID: 49934 RVA: 0x001197E1 File Offset: 0x001179E1
		// (set) Token: 0x0600C30F RID: 49935 RVA: 0x001197F1 File Offset: 0x001179F1
		public unsafe uint ConstCoordinate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_ConstCoordinate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRotator.__PropertyOffset_ConstCoordinate) = (int)value;
			}
		}

		// Token: 0x0600C310 RID: 49936 RVA: 0x00119802 File Offset: 0x00117A02
		static UMaterialExpressionRotator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRotator");
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x00119810 File Offset: 0x00117A10
		protected UMaterialExpressionRotator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067E7 RID: 26599
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRotator";

		// Token: 0x040067E8 RID: 26600
		private static IntPtr _ClassPtr;

		// Token: 0x040067E9 RID: 26601
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067EA RID: 26602
		internal static int __PropertyOffset_Coordinate;

		// Token: 0x040067EB RID: 26603
		[Nullable(2)]
		private FExpressionInput _Coordinate;

		// Token: 0x040067EC RID: 26604
		internal static int __PropertyOffset_Time;

		// Token: 0x040067ED RID: 26605
		[Nullable(2)]
		private FExpressionInput _Time;

		// Token: 0x040067EE RID: 26606
		internal static int __PropertyOffset_CenterX;

		// Token: 0x040067EF RID: 26607
		internal static int __PropertyOffset_CenterY;

		// Token: 0x040067F0 RID: 26608
		internal static int __PropertyOffset_Speed;

		// Token: 0x040067F1 RID: 26609
		internal static int __PropertyOffset_ConstCoordinate;
	}
}
