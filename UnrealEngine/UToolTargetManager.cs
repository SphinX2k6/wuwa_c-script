using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200159D RID: 5533
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ToolTargetManager")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UToolTargetManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EF5 RID: 81653 RVA: 0x001D4595 File Offset: 0x001D2795
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UToolTargetManager._ClassPtr;
		}

		// Token: 0x06013EF6 RID: 81654 RVA: 0x001D45A4 File Offset: 0x001D27A4
		public UToolTargetManager() : this(BuiltinUtils.AllocNativeUObject(UToolTargetManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EF7 RID: 81655 RVA: 0x001D45CC File Offset: 0x001D27CC
		public UToolTargetManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UToolTargetManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E02 RID: 19970
		// (get) Token: 0x06013EF8 RID: 81656 RVA: 0x001D4600 File Offset: 0x001D2800
		// (set) Token: 0x06013EF9 RID: 81657 RVA: 0x001D4639 File Offset: 0x001D2839
		public TArray<UToolTargetFactory> Factories
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UToolTargetFactory> result;
				if ((result = this._Factories) == null)
				{
					result = (this._Factories = new TArray<UToolTargetFactory>(base.NativePtr + (IntPtr)UToolTargetManager.__PropertyOffset_Factories, this));
				}
				return result;
			}
			set
			{
				this.Factories.CopyAssign(value);
			}
		}

		// Token: 0x06013EFA RID: 81658 RVA: 0x001D4647 File Offset: 0x001D2847
		static UToolTargetManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.ToolTargetManager");
		}

		// Token: 0x06013EFB RID: 81659 RVA: 0x001D4655 File Offset: 0x001D2855
		protected UToolTargetManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ACA6 RID: 44198
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.ToolTargetManager";

		// Token: 0x0400ACA7 RID: 44199
		private static IntPtr _ClassPtr;

		// Token: 0x0400ACA8 RID: 44200
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ACA9 RID: 44201
		internal static int __PropertyOffset_Factories;

		// Token: 0x0400ACAA RID: 44202
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UToolTargetFactory> _Factories;
	}
}
