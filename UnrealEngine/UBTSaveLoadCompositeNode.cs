using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015F6 RID: 5622
	[UnrealObjectPath("/Script/KuroAI.BTSaveLoadCompositeNode")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public abstract class UBTSaveLoadCompositeNode : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143EB RID: 82923 RVA: 0x001DBA36 File Offset: 0x001D9C36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTSaveLoadCompositeNode._ClassPtr;
		}

		// Token: 0x17004F54 RID: 20308
		// (get) Token: 0x060143EC RID: 82924 RVA: 0x001DBA42 File Offset: 0x001D9C42
		// (set) Token: 0x060143ED RID: 82925 RVA: 0x001DBA52 File Offset: 0x001D9C52
		public unsafe int UniqueID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTSaveLoadCompositeNode.__PropertyOffset_UniqueID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTSaveLoadCompositeNode.__PropertyOffset_UniqueID) = value;
			}
		}

		// Token: 0x060143EE RID: 82926 RVA: 0x001DBA63 File Offset: 0x001D9C63
		static UBTSaveLoadCompositeNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTSaveLoadCompositeNode");
		}

		// Token: 0x060143EF RID: 82927 RVA: 0x001DBA74 File Offset: 0x001D9C74
		protected UBTSaveLoadCompositeNode() : this(BuiltinUtils.AllocNativeUObject(UBTSaveLoadCompositeNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143F0 RID: 82928 RVA: 0x001DBA9C File Offset: 0x001D9C9C
		protected UBTSaveLoadCompositeNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B039 RID: 45113
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.BTSaveLoadCompositeNode";

		// Token: 0x0400B03A RID: 45114
		private static IntPtr _ClassPtr;

		// Token: 0x0400B03B RID: 45115
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B03C RID: 45116
		internal static int __PropertyOffset_UniqueID;
	}
}
