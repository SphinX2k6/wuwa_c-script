using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001139 RID: 4409
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNode")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class USoundNode : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010218 RID: 66072 RVA: 0x0017C42D File Offset: 0x0017A62D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNode._ClassPtr;
		}

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x06010219 RID: 66073 RVA: 0x0017C43C File Offset: 0x0017A63C
		// (set) Token: 0x0601021A RID: 66074 RVA: 0x0017C475 File Offset: 0x0017A675
		public TArray<USoundNode> ChildNodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USoundNode> result;
				if ((result = this._ChildNodes) == null)
				{
					result = (this._ChildNodes = new TArray<USoundNode>(base.NativePtr + (IntPtr)USoundNode.__PropertyOffset_ChildNodes, this));
				}
				return result;
			}
			set
			{
				this.ChildNodes.CopyAssign(value);
			}
		}

		// Token: 0x0601021B RID: 66075 RVA: 0x0017C483 File Offset: 0x0017A683
		static USoundNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNode");
		}

		// Token: 0x0601021C RID: 66076 RVA: 0x0017C494 File Offset: 0x0017A694
		protected USoundNode() : this(BuiltinUtils.AllocNativeUObject(USoundNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601021D RID: 66077 RVA: 0x0017C4BC File Offset: 0x0017A6BC
		protected USoundNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008ACC RID: 35532
		public new const string __ObjectPath = "/Script/Engine.SoundNode";

		// Token: 0x04008ACD RID: 35533
		private static IntPtr _ClassPtr;

		// Token: 0x04008ACE RID: 35534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008ACF RID: 35535
		internal static int __PropertyOffset_ChildNodes;

		// Token: 0x04008AD0 RID: 35536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USoundNode> _ChildNodes;
	}
}
