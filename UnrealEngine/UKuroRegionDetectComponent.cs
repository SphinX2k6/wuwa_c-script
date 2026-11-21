using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000346 RID: 838
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionDetectComponent")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UKuroRegionDetectComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600561E RID: 22046 RVA: 0x00078BD0 File Offset: 0x00076DD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionDetectComponent._ClassPtr;
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x00078BDC File Offset: 0x00076DDC
		public UKuroRegionDetectComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionDetectComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00078C04 File Offset: 0x00076E04
		public UKuroRegionDetectComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionDetectComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06005621 RID: 22049 RVA: 0x00078C38 File Offset: 0x00076E38
		// (set) Token: 0x06005622 RID: 22050 RVA: 0x00078C71 File Offset: 0x00076E71
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

		// Token: 0x06005623 RID: 22051 RVA: 0x00078C7F File Offset: 0x00076E7F
		public void SetEventTargets([Nullable(new byte[]
		{
			2,
			1
		})] TArray<AActor> DetectTargets, int Id = 0)
		{
			UKuroRegionDetectComponent.__SetEventTargets_Internal(base.NativePtr, (DetectTargets ?? new TArray<AActor>()).NativePtr, Id);
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00078C9C File Offset: 0x00076E9C
		[NullableContext(2)]
		public void SetEventTarget(AActor DetectTarget, int Id = 0)
		{
			UKuroRegionDetectComponent.__SetEventTarget_Internal(base.NativePtr, (DetectTarget != null) ? DetectTarget.NativePtr : IntPtr.Zero, Id);
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00078CBA File Offset: 0x00076EBA
		public void SetDebugMode(bool IsOpen)
		{
			UKuroRegionDetectComponent.__SetDebugMode_Internal(base.NativePtr, IsOpen);
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x00078CC8 File Offset: 0x00076EC8
		public void ResetEventTargets()
		{
			UKuroRegionDetectComponent.__ResetEventTargets_Internal(base.NativePtr);
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x00078CD5 File Offset: 0x00076ED5
		public void RemoveRegionDetect(int Id)
		{
			UKuroRegionDetectComponent.__RemoveRegionDetect_Internal(base.NativePtr, Id);
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x00078CE4 File Offset: 0x00076EE4
		[return: Nullable(2)]
		public unsafe UKuroRegionEventBinder GetRegionEvent(string RegionName, int Id = 0)
		{
			FString fstring = FString.AllocTemp(RegionName);
			UKuroRegionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRegionEventBinder>(UKuroRegionDetectComponent.__GetRegionEvent_Internal(base.NativePtr, fstring, Id));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x00078D14 File Offset: 0x00076F14
		public int GetRegionDetectId()
		{
			return UKuroRegionDetectComponent.__GetRegionDetectId_Internal(base.NativePtr);
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x00078D24 File Offset: 0x00076F24
		public unsafe bool Detect(in FVectorDouble Point, string RegionName)
		{
			FString fstring = FString.AllocTemp(RegionName);
			bool result = UKuroRegionDetectComponent.__Detect_Internal(base.NativePtr, Point, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600562B RID: 22059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEventTargets_Internal(IntPtr @this, IntPtr DetectTargets, int Id);

		// Token: 0x0600562C RID: 22060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEventTarget_Internal(IntPtr @this, IntPtr DetectTarget, int Id);

		// Token: 0x0600562D RID: 22061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDebugMode_Internal(IntPtr @this, bool IsOpen);

		// Token: 0x0600562E RID: 22062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetEventTargets_Internal(IntPtr @this);

		// Token: 0x0600562F RID: 22063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveRegionDetect_Internal(IntPtr @this, int Id);

		// Token: 0x06005630 RID: 22064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegionEvent_Internal(IntPtr @this, in FString RegionName, int Id);

		// Token: 0x06005631 RID: 22065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRegionDetectId_Internal(IntPtr @this);

		// Token: 0x06005632 RID: 22066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Detect_Internal(IntPtr @this, in FVectorDouble Point, in FString RegionName);

		// Token: 0x06005633 RID: 22067 RVA: 0x00078D4F File Offset: 0x00076F4F
		static UKuroRegionDetectComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionDetectComponent");
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x00078D5D File Offset: 0x00076F5D
		protected UKuroRegionDetectComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002353 RID: 9043
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionDetectComponent";

		// Token: 0x04002354 RID: 9044
		private static IntPtr _ClassPtr;

		// Token: 0x04002355 RID: 9045
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002356 RID: 9046
		internal static int __PropertyOffset_RegionMap;

		// Token: 0x04002357 RID: 9047
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UKuroRegionShapeComponent> _RegionMap;
	}
}
