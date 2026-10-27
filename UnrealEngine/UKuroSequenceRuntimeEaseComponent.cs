using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200190B RID: 6411
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSequenceRuntimeEaseComponent")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UKuroSequenceRuntimeEaseComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C95 RID: 97429 RVA: 0x0022D87A File Offset: 0x0022BA7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequenceRuntimeEaseComponent._ClassPtr;
		}

		// Token: 0x06017C96 RID: 97430 RVA: 0x0022D888 File Offset: 0x0022BA88
		public UKuroSequenceRuntimeEaseComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceRuntimeEaseComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C97 RID: 97431 RVA: 0x0022D8B0 File Offset: 0x0022BAB0
		public UKuroSequenceRuntimeEaseComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceRuntimeEaseComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FB2 RID: 24498
		// (get) Token: 0x06017C98 RID: 97432 RVA: 0x0022D8E4 File Offset: 0x0022BAE4
		// (set) Token: 0x06017C99 RID: 97433 RVA: 0x0022D91D File Offset: 0x0022BB1D
		public TMap<int, UKuroSequenceEaseExecutor> EaseExecutors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroSequenceEaseExecutor> result;
				if ((result = this._EaseExecutors) == null)
				{
					result = (this._EaseExecutors = new TMap<int, UKuroSequenceEaseExecutor>(base.NativePtr + (IntPtr)UKuroSequenceRuntimeEaseComponent.__PropertyOffset_EaseExecutors, this));
				}
				return result;
			}
			set
			{
				this.EaseExecutors.CopyAssign(value);
			}
		}

		// Token: 0x06017C9A RID: 97434 RVA: 0x0022D92B File Offset: 0x0022BB2B
		static UKuroSequenceRuntimeEaseComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSequenceRuntimeEaseComponent");
		}

		// Token: 0x06017C9B RID: 97435 RVA: 0x0022D939 File Offset: 0x0022BB39
		protected UKuroSequenceRuntimeEaseComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE69 RID: 52841
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSequenceRuntimeEaseComponent";

		// Token: 0x0400CE6A RID: 52842
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE6B RID: 52843
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE6C RID: 52844
		internal static int __PropertyOffset_EaseExecutors;

		// Token: 0x0400CE6D RID: 52845
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroSequenceEaseExecutor> _EaseExecutors;
	}
}
