using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200175D RID: 5981
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionDetectComponent")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UKuroRegionDetectComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015806 RID: 88070 RVA: 0x001F98F8 File Offset: 0x001F7AF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionDetectComponent._ClassPtr;
		}

		// Token: 0x06015807 RID: 88071 RVA: 0x001F9904 File Offset: 0x001F7B04
		public UKuroRegionDetectComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionDetectComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015808 RID: 88072 RVA: 0x001F992C File Offset: 0x001F7B2C
		public UKuroRegionDetectComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionDetectComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054ED RID: 21741
		// (get) Token: 0x06015809 RID: 88073 RVA: 0x001F9960 File Offset: 0x001F7B60
		// (set) Token: 0x0601580A RID: 88074 RVA: 0x001F9999 File Offset: 0x001F7B99
		public TMap<string, UKuroRegionShapeComponent> RegionMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UKuroRegionShapeComponent> result;
				if ((result = this._RegionMap) == null)
				{
					result = (this._RegionMap = new TMap<string, UKuroRegionShapeComponent>(base.NativePtr + (IntPtr)UKuroRegionDetectComponent.__PropertyOffset_RegionMap, this));
				}
				return result;
			}
			set
			{
				this.RegionMap.CopyAssign(value);
			}
		}

		// Token: 0x170054EE RID: 21742
		// (get) Token: 0x0601580B RID: 88075 RVA: 0x001F99A8 File Offset: 0x001F7BA8
		// (set) Token: 0x0601580C RID: 88076 RVA: 0x001F99E1 File Offset: 0x001F7BE1
		public TMap<int, FRegionDetectInfo> RegionDetectMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FRegionDetectInfo> result;
				if ((result = this._RegionDetectMap) == null)
				{
					result = (this._RegionDetectMap = new TMap<int, FRegionDetectInfo>(base.NativePtr + (IntPtr)UKuroRegionDetectComponent.__PropertyOffset_RegionDetectMap, this));
				}
				return result;
			}
			set
			{
				this.RegionDetectMap.CopyAssign(value);
			}
		}

		// Token: 0x0601580D RID: 88077 RVA: 0x001F99EF File Offset: 0x001F7BEF
		public void SetEventTargets([Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> DetectTargets, int Id = 0)
		{
			UKuroRegionDetectComponent.__SetEventTargets_Internal(base.NativePtr, (DetectTargets ?? new TArray<AActor>()).NativePtr, Id);
		}

		// Token: 0x0601580E RID: 88078 RVA: 0x001F9A0C File Offset: 0x001F7C0C
		[NullableContext(2)]
		public void SetEventTarget(AActor DetectTarget, int Id = 0)
		{
			UKuroRegionDetectComponent.__SetEventTarget_Internal(base.NativePtr, (DetectTarget != null) ? DetectTarget.NativePtr : IntPtr.Zero, Id);
		}

		// Token: 0x0601580F RID: 88079 RVA: 0x001F9A2A File Offset: 0x001F7C2A
		public void SetDebugMode(bool IsOpen)
		{
			UKuroRegionDetectComponent.__SetDebugMode_Internal(base.NativePtr, IsOpen);
		}

		// Token: 0x06015810 RID: 88080 RVA: 0x001F9A38 File Offset: 0x001F7C38
		public void ResetEventTargets()
		{
			UKuroRegionDetectComponent.__ResetEventTargets_Internal(base.NativePtr);
		}

		// Token: 0x06015811 RID: 88081 RVA: 0x001F9A45 File Offset: 0x001F7C45
		public void RemoveRegionDetect(int Id)
		{
			UKuroRegionDetectComponent.__RemoveRegionDetect_Internal(base.NativePtr, Id);
		}

		// Token: 0x06015812 RID: 88082 RVA: 0x001F9A54 File Offset: 0x001F7C54
		[return: Nullable(2)]
		public unsafe UKuroRegionEventBinder GetRegionEvent(string RegionName, int Id = 0)
		{
			FString fstring = FString.AllocTemp(RegionName);
			UKuroRegionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRegionEventBinder>(UKuroRegionDetectComponent.__GetRegionEvent_Internal(base.NativePtr, fstring, Id));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06015813 RID: 88083 RVA: 0x001F9A84 File Offset: 0x001F7C84
		public int GetRegionDetectId()
		{
			return UKuroRegionDetectComponent.__GetRegionDetectId_Internal(base.NativePtr);
		}

		// Token: 0x06015814 RID: 88084 RVA: 0x001F9A94 File Offset: 0x001F7C94
		public unsafe bool Detect(in FVectorDouble Point, string RegionName)
		{
			FString fstring = FString.AllocTemp(RegionName);
			bool result = UKuroRegionDetectComponent.__Detect_Internal(base.NativePtr, Point, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06015815 RID: 88085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEventTargets_Internal(IntPtr @this, IntPtr DetectTargets, int Id);

		// Token: 0x06015816 RID: 88086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEventTarget_Internal(IntPtr @this, IntPtr DetectTarget, int Id);

		// Token: 0x06015817 RID: 88087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDebugMode_Internal(IntPtr @this, bool IsOpen);

		// Token: 0x06015818 RID: 88088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetEventTargets_Internal(IntPtr @this);

		// Token: 0x06015819 RID: 88089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveRegionDetect_Internal(IntPtr @this, int Id);

		// Token: 0x0601581A RID: 88090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegionEvent_Internal(IntPtr @this, in FString RegionName, int Id);

		// Token: 0x0601581B RID: 88091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRegionDetectId_Internal(IntPtr @this);

		// Token: 0x0601581C RID: 88092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Detect_Internal(IntPtr @this, in FVectorDouble Point, in FString RegionName);

		// Token: 0x0601581D RID: 88093 RVA: 0x001F9ABF File Offset: 0x001F7CBF
		static UKuroRegionDetectComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionDetectComponent");
		}

		// Token: 0x0601581E RID: 88094 RVA: 0x001F9ACD File Offset: 0x001F7CCD
		protected UKuroRegionDetectComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBB7 RID: 48055
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionDetectComponent";

		// Token: 0x0400BBB8 RID: 48056
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBB9 RID: 48057
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBBA RID: 48058
		internal static int __PropertyOffset_RegionMap;

		// Token: 0x0400BBBB RID: 48059
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UKuroRegionShapeComponent> _RegionMap;

		// Token: 0x0400BBBC RID: 48060
		internal static int __PropertyOffset_RegionDetectMap;

		// Token: 0x0400BBBD RID: 48061
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FRegionDetectInfo> _RegionDetectMap;
	}
}
