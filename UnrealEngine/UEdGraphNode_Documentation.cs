using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A49 RID: 2633
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EdGraphNode_Documentation")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UEdGraphNode_Documentation : UEdGraphNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008EF1 RID: 36593 RVA: 0x000CC678 File Offset: 0x000CA878
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEdGraphNode_Documentation._ClassPtr;
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x000CC684 File Offset: 0x000CA884
		public UEdGraphNode_Documentation() : this(BuiltinUtils.AllocNativeUObject(UEdGraphNode_Documentation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x000CC6AC File Offset: 0x000CA8AC
		public UEdGraphNode_Documentation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEdGraphNode_Documentation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06008EF4 RID: 36596 RVA: 0x000CC6DF File Offset: 0x000CA8DF
		// (set) Token: 0x06008EF5 RID: 36597 RVA: 0x000CC6F3 File Offset: 0x000CA8F3
		public unsafe string Link
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEdGraphNode_Documentation.__PropertyOffset_Link)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEdGraphNode_Documentation.__PropertyOffset_Link)), value);
			}
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06008EF6 RID: 36598 RVA: 0x000CC708 File Offset: 0x000CA908
		// (set) Token: 0x06008EF7 RID: 36599 RVA: 0x000CC71C File Offset: 0x000CA91C
		public unsafe string Excerpt
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEdGraphNode_Documentation.__PropertyOffset_Excerpt)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEdGraphNode_Documentation.__PropertyOffset_Excerpt)), value);
			}
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x000CC731 File Offset: 0x000CA931
		static UEdGraphNode_Documentation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EdGraphNode_Documentation");
		}

		// Token: 0x06008EF9 RID: 36601 RVA: 0x000CC73F File Offset: 0x000CA93F
		protected UEdGraphNode_Documentation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400468D RID: 18061
		public new const string __ObjectPath = "/Script/Engine.EdGraphNode_Documentation";

		// Token: 0x0400468E RID: 18062
		private static IntPtr _ClassPtr;

		// Token: 0x0400468F RID: 18063
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004690 RID: 18064
		internal static int __PropertyOffset_Link;

		// Token: 0x04004691 RID: 18065
		internal static int __PropertyOffset_Excerpt;
	}
}
