using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AC RID: 940
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARLifeCycleComponent")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UARLifeCycleComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003425 RID: 13349 RVA: 0x0004FB90 File Offset: 0x0004DD90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARLifeCycleComponent._ClassPtr;
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x0004FB9C File Offset: 0x0004DD9C
		public UARLifeCycleComponent() : this(BuiltinUtils.AllocNativeUObject(UARLifeCycleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x0004FBC4 File Offset: 0x0004DDC4
		public UARLifeCycleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARLifeCycleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06003428 RID: 13352 RVA: 0x0004FBF8 File Offset: 0x0004DDF8
		// (set) Token: 0x06003429 RID: 13353 RVA: 0x0004FC31 File Offset: 0x0004DE31
		public FInstanceARActorSpawnedDelegate OnARActorSpawnedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FInstanceARActorSpawnedDelegate result;
				if ((result = this._OnARActorSpawnedDelegate) == null)
				{
					result = (this._OnARActorSpawnedDelegate = new FInstanceARActorSpawnedDelegate(base.NativePtr + (IntPtr)UARLifeCycleComponent.__PropertyOffset_OnARActorSpawnedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARLifeCycleComponent.__PropertyOffset_OnARActorSpawnedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x0004FC54 File Offset: 0x0004DE54
		// (set) Token: 0x0600342B RID: 13355 RVA: 0x0004FC8D File Offset: 0x0004DE8D
		public FInstanceARActorToBeDestroyedDelegate OnARActorToBeDestroyedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FInstanceARActorToBeDestroyedDelegate result;
				if ((result = this._OnARActorToBeDestroyedDelegate) == null)
				{
					result = (this._OnARActorToBeDestroyedDelegate = new FInstanceARActorToBeDestroyedDelegate(base.NativePtr + (IntPtr)UARLifeCycleComponent.__PropertyOffset_OnARActorToBeDestroyedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARLifeCycleComponent.__PropertyOffset_OnARActorToBeDestroyedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x0004FCAE File Offset: 0x0004DEAE
		public void ServerSpawnARActor(UClassStackOnlyPtr ComponentClass, FGuid NativeID)
		{
			UARLifeCycleComponent.__ServerSpawnARActor_Internal(base.NativePtr, ComponentClass._NativePtr, NativeID);
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x0004FCC2 File Offset: 0x0004DEC2
		[NullableContext(2)]
		public void ServerDestroyARActor(AARActor Actor)
		{
			UARLifeCycleComponent.__ServerDestroyARActor_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600342E RID: 13358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSpawnARActor_Internal(IntPtr @this, IntPtr ComponentClass, FGuid NativeID);

		// Token: 0x0600342F RID: 13359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerDestroyARActor_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06003430 RID: 13360 RVA: 0x0004FCDF File Offset: 0x0004DEDF
		static UARLifeCycleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARLifeCycleComponent");
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x0004FCED File Offset: 0x0004DEED
		protected UARLifeCycleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400169F RID: 5791
		public new const string __ObjectPath = "/Script/AugmentedReality.ARLifeCycleComponent";

		// Token: 0x040016A0 RID: 5792
		private static IntPtr _ClassPtr;

		// Token: 0x040016A1 RID: 5793
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040016A2 RID: 5794
		public static IntPtr __InstanceARActorToBeDestroyedDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040016A3 RID: 5795
		public static IntPtr __InstanceARActorSpawnedDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040016A4 RID: 5796
		internal static int __PropertyOffset_OnARActorSpawnedDelegate;

		// Token: 0x040016A5 RID: 5797
		[Nullable(2)]
		private FInstanceARActorSpawnedDelegate _OnARActorSpawnedDelegate;

		// Token: 0x040016A6 RID: 5798
		internal static int __PropertyOffset_OnARActorToBeDestroyedDelegate;

		// Token: 0x040016A7 RID: 5799
		[Nullable(2)]
		private FInstanceARActorToBeDestroyedDelegate _OnARActorToBeDestroyedDelegate;
	}
}
