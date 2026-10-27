using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F4 RID: 244
	[UnrealObjectPath("/Script/AIModule.AIPerceptionStimuliSourceComponent")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UAIPerceptionStimuliSourceComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001316 RID: 4886 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIPerceptionStimuliSourceComponent._ClassPtr;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0001C400 File Offset: 0x0001A600
		public UAIPerceptionStimuliSourceComponent() : this(BuiltinUtils.AllocNativeUObject(UAIPerceptionStimuliSourceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0001C428 File Offset: 0x0001A628
		[NullableContext(1)]
		public UAIPerceptionStimuliSourceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIPerceptionStimuliSourceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0001C45B File Offset: 0x0001A65B
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0001C474 File Offset: 0x0001A674
		public unsafe bool bAutoRegisterAsSource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAIPerceptionStimuliSourceComponent.__PropertyOffset_bAutoRegisterAsSource) & UAIPerceptionStimuliSourceComponent.__PropertyMask_bAutoRegisterAsSource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAIPerceptionStimuliSourceComponent.__PropertyOffset_bAutoRegisterAsSource) = ((*(base.NativePtr + (IntPtr)UAIPerceptionStimuliSourceComponent.__PropertyOffset_bAutoRegisterAsSource) & ~UAIPerceptionStimuliSourceComponent.__PropertyMask_bAutoRegisterAsSource) | (value ? UAIPerceptionStimuliSourceComponent.__PropertyMask_bAutoRegisterAsSource : 0));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x0001C4A4 File Offset: 0x0001A6A4
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x0001C4DD File Offset: 0x0001A6DD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UAISense>> RegisterAsSourceForSenses
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UAISense>> result;
				if ((result = this._RegisterAsSourceForSenses) == null)
				{
					result = (this._RegisterAsSourceForSenses = new TArray<TSubclassOf<UAISense>>(base.NativePtr + (IntPtr)UAIPerceptionStimuliSourceComponent.__PropertyOffset_RegisterAsSourceForSenses, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.RegisterAsSourceForSenses.CopyAssign(value);
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0001C4EB File Offset: 0x0001A6EB
		public void UnregisterFromSense([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAISense> SenseClass)
		{
			UAIPerceptionStimuliSourceComponent.__UnregisterFromSense_Internal(base.NativePtr, SenseClass._NativePtr);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0001C4FE File Offset: 0x0001A6FE
		public void UnregisterFromPerceptionSystem()
		{
			UAIPerceptionStimuliSourceComponent.__UnregisterFromPerceptionSystem_Internal(base.NativePtr);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0001C50B File Offset: 0x0001A70B
		public void RegisterWithPerceptionSystem()
		{
			UAIPerceptionStimuliSourceComponent.__RegisterWithPerceptionSystem_Internal(base.NativePtr);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0001C518 File Offset: 0x0001A718
		public void RegisterForSense([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAISense> SenseClass)
		{
			UAIPerceptionStimuliSourceComponent.__RegisterForSense_Internal(base.NativePtr, SenseClass._NativePtr);
		}

		// Token: 0x06001321 RID: 4897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterFromSense_Internal(IntPtr @this, IntPtr SenseClass);

		// Token: 0x06001322 RID: 4898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterFromPerceptionSystem_Internal(IntPtr @this);

		// Token: 0x06001323 RID: 4899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterWithPerceptionSystem_Internal(IntPtr @this);

		// Token: 0x06001324 RID: 4900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterForSense_Internal(IntPtr @this, IntPtr SenseClass);

		// Token: 0x06001325 RID: 4901 RVA: 0x0001C52B File Offset: 0x0001A72B
		static UAIPerceptionStimuliSourceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIPerceptionStimuliSourceComponent");
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0001C539 File Offset: 0x0001A739
		protected UAIPerceptionStimuliSourceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000368 RID: 872
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIPerceptionStimuliSourceComponent";

		// Token: 0x04000369 RID: 873
		private static IntPtr _ClassPtr;

		// Token: 0x0400036A RID: 874
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400036B RID: 875
		internal static int __PropertyOffset_bAutoRegisterAsSource;

		// Token: 0x0400036C RID: 876
		internal static byte __PropertyMask_bAutoRegisterAsSource;

		// Token: 0x0400036D RID: 877
		internal static int __PropertyOffset_RegisterAsSourceForSenses;

		// Token: 0x0400036E RID: 878
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UAISense>> _RegisterAsSourceForSenses;
	}
}
