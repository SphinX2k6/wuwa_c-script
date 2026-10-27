using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E24 RID: 3620
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRayTracingQualitySwitchEx")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UMaterialExpressionRayTracingQualitySwitchEx : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2BF RID: 49855 RVA: 0x00118DD5 File Offset: 0x00116FD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRayTracingQualitySwitchEx._ClassPtr;
		}

		// Token: 0x0600C2C0 RID: 49856 RVA: 0x00118DE4 File Offset: 0x00116FE4
		public UMaterialExpressionRayTracingQualitySwitchEx() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRayTracingQualitySwitchEx.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2C1 RID: 49857 RVA: 0x00118E0C File Offset: 0x0011700C
		public UMaterialExpressionRayTracingQualitySwitchEx(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRayTracingQualitySwitchEx.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x0600C2C2 RID: 49858 RVA: 0x00118E40 File Offset: 0x00117040
		// (set) Token: 0x0600C2C3 RID: 49859 RVA: 0x00118E79 File Offset: 0x00117079
		public FExpressionInput Normal
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Normal) == null)
				{
					result = (this._Normal = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitchEx.__PropertyOffset_Normal, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitchEx.__PropertyOffset_Normal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x0600C2C4 RID: 49860 RVA: 0x00118E9C File Offset: 0x0011709C
		// (set) Token: 0x0600C2C5 RID: 49861 RVA: 0x00118ED5 File Offset: 0x001170D5
		public FExpressionInput RayTracedReflections
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._RayTracedReflections) == null)
				{
					result = (this._RayTracedReflections = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitchEx.__PropertyOffset_RayTracedReflections, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitchEx.__PropertyOffset_RayTracedReflections, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x0600C2C6 RID: 49862 RVA: 0x00118EF8 File Offset: 0x001170F8
		// (set) Token: 0x0600C2C7 RID: 49863 RVA: 0x00118F31 File Offset: 0x00117131
		public FExpressionInput RayTracedGI
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._RayTracedGI) == null)
				{
					result = (this._RayTracedGI = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitchEx.__PropertyOffset_RayTracedGI, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRayTracingQualitySwitchEx.__PropertyOffset_RayTracedGI, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C2C8 RID: 49864 RVA: 0x00118F52 File Offset: 0x00117152
		static UMaterialExpressionRayTracingQualitySwitchEx()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRayTracingQualitySwitchEx");
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x00118F60 File Offset: 0x00117160
		protected UMaterialExpressionRayTracingQualitySwitchEx(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067B4 RID: 26548
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRayTracingQualitySwitchEx";

		// Token: 0x040067B5 RID: 26549
		private static IntPtr _ClassPtr;

		// Token: 0x040067B6 RID: 26550
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067B7 RID: 26551
		internal static int __PropertyOffset_Normal;

		// Token: 0x040067B8 RID: 26552
		[Nullable(2)]
		private FExpressionInput _Normal;

		// Token: 0x040067B9 RID: 26553
		internal static int __PropertyOffset_RayTracedReflections;

		// Token: 0x040067BA RID: 26554
		[Nullable(2)]
		private FExpressionInput _RayTracedReflections;

		// Token: 0x040067BB RID: 26555
		internal static int __PropertyOffset_RayTracedGI;

		// Token: 0x040067BC RID: 26556
		[Nullable(2)]
		private FExpressionInput _RayTracedGI;
	}
}
