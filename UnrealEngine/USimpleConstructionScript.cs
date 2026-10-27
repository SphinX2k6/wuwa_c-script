using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010EA RID: 4330
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SimpleConstructionScript")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class USimpleConstructionScript : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F87C RID: 63612 RVA: 0x0016F86E File Offset: 0x0016DA6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimpleConstructionScript._ClassPtr;
		}

		// Token: 0x0600F87D RID: 63613 RVA: 0x0016F87C File Offset: 0x0016DA7C
		public USimpleConstructionScript() : this(BuiltinUtils.AllocNativeUObject(USimpleConstructionScript.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F87E RID: 63614 RVA: 0x0016F8A4 File Offset: 0x0016DAA4
		public USimpleConstructionScript(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimpleConstructionScript.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x0600F87F RID: 63615 RVA: 0x0016F8D8 File Offset: 0x0016DAD8
		// (set) Token: 0x0600F880 RID: 63616 RVA: 0x0016F911 File Offset: 0x0016DB11
		public TArray<USCS_Node> RootNodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USCS_Node> result;
				if ((result = this._RootNodes) == null)
				{
					result = (this._RootNodes = new TArray<USCS_Node>(base.NativePtr + (IntPtr)USimpleConstructionScript.__PropertyOffset_RootNodes, this));
				}
				return result;
			}
			set
			{
				this.RootNodes.CopyAssign(value);
			}
		}

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x0600F881 RID: 63617 RVA: 0x0016F920 File Offset: 0x0016DB20
		// (set) Token: 0x0600F882 RID: 63618 RVA: 0x0016F959 File Offset: 0x0016DB59
		public TArray<USCS_Node> AllNodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USCS_Node> result;
				if ((result = this._AllNodes) == null)
				{
					result = (this._AllNodes = new TArray<USCS_Node>(base.NativePtr + (IntPtr)USimpleConstructionScript.__PropertyOffset_AllNodes, this));
				}
				return result;
			}
			set
			{
				this.AllNodes.CopyAssign(value);
			}
		}

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0600F883 RID: 63619 RVA: 0x0016F967 File Offset: 0x0016DB67
		// (set) Token: 0x0600F884 RID: 63620 RVA: 0x0016F97B File Offset: 0x0016DB7B
		[Nullable(2)]
		public unsafe USCS_Node DefaultSceneRootNode
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USCS_Node>(base.NativePtr / (IntPtr)sizeof(void*) + USimpleConstructionScript.__PropertyOffset_DefaultSceneRootNode);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USimpleConstructionScript.__PropertyOffset_DefaultSceneRootNode, value);
			}
		}

		// Token: 0x0600F885 RID: 63621 RVA: 0x0016F990 File Offset: 0x0016DB90
		static USimpleConstructionScript()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SimpleConstructionScript");
		}

		// Token: 0x0600F886 RID: 63622 RVA: 0x0016F99E File Offset: 0x0016DB9E
		protected USimpleConstructionScript(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008640 RID: 34368
		public new const string __ObjectPath = "/Script/Engine.SimpleConstructionScript";

		// Token: 0x04008641 RID: 34369
		private static IntPtr _ClassPtr;

		// Token: 0x04008642 RID: 34370
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008643 RID: 34371
		internal static int __PropertyOffset_RootNodes;

		// Token: 0x04008644 RID: 34372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USCS_Node> _RootNodes;

		// Token: 0x04008645 RID: 34373
		internal static int __PropertyOffset_AllNodes;

		// Token: 0x04008646 RID: 34374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USCS_Node> _AllNodes;

		// Token: 0x04008647 RID: 34375
		internal static int __PropertyOffset_DefaultSceneRootNode;
	}
}
