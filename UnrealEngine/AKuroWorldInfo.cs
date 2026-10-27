using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE7 RID: 7143
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldInfo")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1176)]
	public class AKuroWorldInfo : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B7AA RID: 112554 RVA: 0x0028766E File Offset: 0x0028586E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWorldInfo._ClassPtr;
		}

		// Token: 0x0601B7AB RID: 112555 RVA: 0x0028767C File Offset: 0x0028587C
		public AKuroWorldInfo() : this(BuiltinUtils.AllocNativeUObject(AKuroWorldInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B7AC RID: 112556 RVA: 0x002876A4 File Offset: 0x002858A4
		public AKuroWorldInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWorldInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E97 RID: 28311
		// (get) Token: 0x0601B7AD RID: 112557 RVA: 0x002876D8 File Offset: 0x002858D8
		// (set) Token: 0x0601B7AE RID: 112558 RVA: 0x00287711 File Offset: 0x00285911
		public FKuroLandscapeInfo M_LandscapeInfo
		{
			get
			{
				base.FastCheckIsValid();
				FKuroLandscapeInfo result;
				if ((result = this._M_LandscapeInfo) == null)
				{
					result = (this._M_LandscapeInfo = new FKuroLandscapeInfo(base.NativePtr + (IntPtr)AKuroWorldInfo.__PropertyOffset_M_LandscapeInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroLandscapeInfo.StaticStruct(), base.NativePtr + (IntPtr)AKuroWorldInfo.__PropertyOffset_M_LandscapeInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E98 RID: 28312
		// (get) Token: 0x0601B7AF RID: 112559 RVA: 0x00287734 File Offset: 0x00285934
		// (set) Token: 0x0601B7B0 RID: 112560 RVA: 0x0028776D File Offset: 0x0028596D
		public TArray<FKuroStreamingLevelInfo> M_StreamingLevelInfoList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroStreamingLevelInfo> result;
				if ((result = this._M_StreamingLevelInfoList) == null)
				{
					result = (this._M_StreamingLevelInfoList = new TArray<FKuroStreamingLevelInfo>(base.NativePtr + (IntPtr)AKuroWorldInfo.__PropertyOffset_M_StreamingLevelInfoList, this));
				}
				return result;
			}
			set
			{
				this.M_StreamingLevelInfoList.CopyAssign(value);
			}
		}

		// Token: 0x0601B7B1 RID: 112561 RVA: 0x0028777C File Offset: 0x0028597C
		[NullableContext(2)]
		public unsafe int GetSLInfo(in FName PackageName, ref FKuroStreamingLevelInfo LandscapeInfo)
		{
			fixed (FName* ptr = &PackageName)
			{
				void* ptr2 = (void*)ptr;
				return AKuroWorldInfo.__GetSLInfo_Internal(base.NativePtr, PackageName, (LandscapeInfo ?? new FKuroStreamingLevelInfo()).NativePtr);
			}
		}

		// Token: 0x0601B7B2 RID: 112562 RVA: 0x002877AA File Offset: 0x002859AA
		[NullableContext(2)]
		public void GetLandscapeInfo(ref FKuroLandscapeInfo LandscapeInfo)
		{
			AKuroWorldInfo.__GetLandscapeInfo_Internal(base.NativePtr, (LandscapeInfo ?? new FKuroLandscapeInfo()).NativePtr);
		}

		// Token: 0x0601B7B3 RID: 112563 RVA: 0x002877C7 File Offset: 0x002859C7
		[NullableContext(2)]
		public static AKuroWorldInfo BP_GetInstance(UObject WorldContextObject, bool AutoCreate = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroWorldInfo>(AKuroWorldInfo.__BP_GetInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, AutoCreate));
		}

		// Token: 0x0601B7B4 RID: 112564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSLInfo_Internal(IntPtr @this, in FName PackageName, IntPtr LandscapeInfo);

		// Token: 0x0601B7B5 RID: 112565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLandscapeInfo_Internal(IntPtr @this, IntPtr LandscapeInfo);

		// Token: 0x0601B7B6 RID: 112566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_GetInstance_Internal(IntPtr WorldContextObject, bool AutoCreate);

		// Token: 0x0601B7B7 RID: 112567 RVA: 0x002877E4 File Offset: 0x002859E4
		static AKuroWorldInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldInfo");
		}

		// Token: 0x0601B7B8 RID: 112568 RVA: 0x002877F2 File Offset: 0x002859F2
		protected AKuroWorldInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EC8F RID: 60559
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldInfo";

		// Token: 0x0400EC90 RID: 60560
		private static IntPtr _ClassPtr;

		// Token: 0x0400EC91 RID: 60561
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EC92 RID: 60562
		internal static int __PropertyOffset_M_LandscapeInfo;

		// Token: 0x0400EC93 RID: 60563
		[Nullable(2)]
		private FKuroLandscapeInfo _M_LandscapeInfo;

		// Token: 0x0400EC94 RID: 60564
		internal static int __PropertyOffset_M_StreamingLevelInfoList;

		// Token: 0x0400EC95 RID: 60565
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroStreamingLevelInfo> _M_StreamingLevelInfoList;
	}
}
