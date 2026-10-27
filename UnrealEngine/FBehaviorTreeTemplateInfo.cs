using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200011E RID: 286
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BehaviorTreeTemplateInfo")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FBehaviorTreeTemplateInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x0001ECA6 File Offset: 0x0001CEA6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBehaviorTreeTemplateInfo._ScriptStructPtr != 0) ? FBehaviorTreeTemplateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.BehaviorTreeTemplateInfo", ref FBehaviorTreeTemplateInfo._ScriptStructPtr);
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0001ECCA File Offset: 0x0001CECA
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x0001ECDE File Offset: 0x0001CEDE
		public unsafe UBehaviorTree Asset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBehaviorTree>(base.NativePtr / (IntPtr)sizeof(void*) + FBehaviorTreeTemplateInfo.__PropertyOffset_Asset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBehaviorTreeTemplateInfo.__PropertyOffset_Asset, value);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0001ECF3 File Offset: 0x0001CEF3
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x0001ED07 File Offset: 0x0001CF07
		public unsafe UBTCompositeNode Template
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBTCompositeNode>(base.NativePtr / (IntPtr)sizeof(void*) + FBehaviorTreeTemplateInfo.__PropertyOffset_Template);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBehaviorTreeTemplateInfo.__PropertyOffset_Template, value);
			}
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0001ED1C File Offset: 0x0001CF1C
		public FBehaviorTreeTemplateInfo()
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0001ED24 File Offset: 0x0001CF24
		[NullableContext(1)]
		public FBehaviorTreeTemplateInfo(UBehaviorTree Asset, UBTCompositeNode Template)
		{
			this.Asset = Asset;
			this.Template = Template;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0001ED3A File Offset: 0x0001CF3A
		protected override IntPtr GetUStructPtr()
		{
			return FBehaviorTreeTemplateInfo.StaticStruct();
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0001ED46 File Offset: 0x0001CF46
		public FBehaviorTreeTemplateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0001ED50 File Offset: 0x0001CF50
		public FBehaviorTreeTemplateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0001ED5B File Offset: 0x0001CF5B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBehaviorTreeTemplateInfo(Pointer, false, true);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0001ED65 File Offset: 0x0001CF65
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBehaviorTreeTemplateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000459 RID: 1113
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.BehaviorTreeTemplateInfo";

		// Token: 0x0400045A RID: 1114
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400045B RID: 1115
		internal static int __PropertyOffset_Asset;

		// Token: 0x0400045C RID: 1116
		internal static int __PropertyOffset_Template;
	}
}
