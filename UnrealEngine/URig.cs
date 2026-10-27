using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001092 RID: 4242
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Rig")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class URig : UObject, IUnrealUObject, IUnrealObject, INodeMappingProviderInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600F26E RID: 62062 RVA: 0x00167B81 File Offset: 0x00165D81
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URig._ClassPtr;
		}

		// Token: 0x0600F26F RID: 62063 RVA: 0x00167B8D File Offset: 0x00165D8D
		int INodeMappingProviderInterface.InterfaceOffset()
		{
			return URig.__InterfaceOffset_INodeMappingProviderInterface;
		}

		// Token: 0x0600F270 RID: 62064 RVA: 0x00167B94 File Offset: 0x00165D94
		public URig() : this(BuiltinUtils.AllocNativeUObject(URig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F271 RID: 62065 RVA: 0x00167BBC File Offset: 0x00165DBC
		public URig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0600F272 RID: 62066 RVA: 0x00167BF0 File Offset: 0x00165DF0
		// (set) Token: 0x0600F273 RID: 62067 RVA: 0x00167C29 File Offset: 0x00165E29
		public TArray<FTransformBase> TransformBases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransformBase> result;
				if ((result = this._TransformBases) == null)
				{
					result = (this._TransformBases = new TArray<FTransformBase>(base.NativePtr + (IntPtr)URig.__PropertyOffset_TransformBases, this));
				}
				return result;
			}
			set
			{
				this.TransformBases.CopyAssign(value);
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0600F274 RID: 62068 RVA: 0x00167C38 File Offset: 0x00165E38
		// (set) Token: 0x0600F275 RID: 62069 RVA: 0x00167C71 File Offset: 0x00165E71
		public TArray<FNode> Nodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNode> result;
				if ((result = this._Nodes) == null)
				{
					result = (this._Nodes = new TArray<FNode>(base.NativePtr + (IntPtr)URig.__PropertyOffset_Nodes, this));
				}
				return result;
			}
			set
			{
				this.Nodes.CopyAssign(value);
			}
		}

		// Token: 0x0600F276 RID: 62070 RVA: 0x00167C7F File Offset: 0x00165E7F
		static URig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Rig");
		}

		// Token: 0x0600F277 RID: 62071 RVA: 0x00167C8D File Offset: 0x00165E8D
		protected URig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400838A RID: 33674
		internal static int __InterfaceOffset_INodeMappingProviderInterface;

		// Token: 0x0400838B RID: 33675
		public new const string __ObjectPath = "/Script/Engine.Rig";

		// Token: 0x0400838C RID: 33676
		private static IntPtr _ClassPtr;

		// Token: 0x0400838D RID: 33677
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400838E RID: 33678
		internal static int __PropertyOffset_TransformBases;

		// Token: 0x0400838F RID: 33679
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransformBase> _TransformBases;

		// Token: 0x04008390 RID: 33680
		internal static int __PropertyOffset_Nodes;

		// Token: 0x04008391 RID: 33681
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNode> _Nodes;
	}
}
