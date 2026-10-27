using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200156E RID: 5486
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InputBehaviorSet")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInputBehaviorSet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013DC9 RID: 81353 RVA: 0x001D2A8A File Offset: 0x001D0C8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputBehaviorSet._ClassPtr;
		}

		// Token: 0x06013DCA RID: 81354 RVA: 0x001D2A98 File Offset: 0x001D0C98
		public UInputBehaviorSet() : this(BuiltinUtils.AllocNativeUObject(UInputBehaviorSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DCB RID: 81355 RVA: 0x001D2AC0 File Offset: 0x001D0CC0
		public UInputBehaviorSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputBehaviorSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DCC RID: 19916
		// (get) Token: 0x06013DCC RID: 81356 RVA: 0x001D2AF4 File Offset: 0x001D0CF4
		// (set) Token: 0x06013DCD RID: 81357 RVA: 0x001D2B2D File Offset: 0x001D0D2D
		public TArray<FBehaviorInfo> Behaviors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBehaviorInfo> result;
				if ((result = this._Behaviors) == null)
				{
					result = (this._Behaviors = new TArray<FBehaviorInfo>(base.NativePtr + (IntPtr)UInputBehaviorSet.__PropertyOffset_Behaviors, this));
				}
				return result;
			}
			set
			{
				this.Behaviors.CopyAssign(value);
			}
		}

		// Token: 0x06013DCE RID: 81358 RVA: 0x001D2B3B File Offset: 0x001D0D3B
		static UInputBehaviorSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InputBehaviorSet");
		}

		// Token: 0x06013DCF RID: 81359 RVA: 0x001D2B49 File Offset: 0x001D0D49
		protected UInputBehaviorSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABEB RID: 44011
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InputBehaviorSet";

		// Token: 0x0400ABEC RID: 44012
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABED RID: 44013
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABEE RID: 44014
		internal static int __PropertyOffset_Behaviors;

		// Token: 0x0400ABEF RID: 44015
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBehaviorInfo> _Behaviors;
	}
}
