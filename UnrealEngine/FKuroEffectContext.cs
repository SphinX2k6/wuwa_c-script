using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003E2 RID: 994
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectContext")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroEffectContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006171 RID: 24945 RVA: 0x0008B5C6 File Offset: 0x000897C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectContext._ScriptStructPtr != 0) ? FKuroEffectContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectContext", ref FKuroEffectContext._ScriptStructPtr);
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06006172 RID: 24946 RVA: 0x0008B5EA File Offset: 0x000897EA
		// (set) Token: 0x06006173 RID: 24947 RVA: 0x0008B5FA File Offset: 0x000897FA
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06006174 RID: 24948 RVA: 0x0008B60B File Offset: 0x0008980B
		// (set) Token: 0x06006175 RID: 24949 RVA: 0x0008B61F File Offset: 0x0008981F
		[Nullable(2)]
		public unsafe UObject SourceObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroEffectContext.__PropertyOffset_SourceObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroEffectContext.__PropertyOffset_SourceObject, value);
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06006176 RID: 24950 RVA: 0x0008B634 File Offset: 0x00089834
		// (set) Token: 0x06006177 RID: 24951 RVA: 0x0008B644 File Offset: 0x00089844
		public unsafe bool DisablePostProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_DisablePostProcess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_DisablePostProcess) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x0008B655 File Offset: 0x00089855
		// (set) Token: 0x06006179 RID: 24953 RVA: 0x0008B665 File Offset: 0x00089865
		public unsafe int CreateFromType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_CreateFromType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_CreateFromType) = value;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600617A RID: 24954 RVA: 0x0008B676 File Offset: 0x00089876
		// (set) Token: 0x0600617B RID: 24955 RVA: 0x0008B686 File Offset: 0x00089886
		public unsafe int PlayFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_PlayFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_PlayFlag) = value;
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600617C RID: 24956 RVA: 0x0008B697 File Offset: 0x00089897
		// (set) Token: 0x0600617D RID: 24957 RVA: 0x0008B6A7 File Offset: 0x000898A7
		public unsafe bool EndInnerAnimNotifyStatesOnStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_EndInnerAnimNotifyStatesOnStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_EndInnerAnimNotifyStatesOnStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x0600617E RID: 24958 RVA: 0x0008B6B8 File Offset: 0x000898B8
		// (set) Token: 0x0600617F RID: 24959 RVA: 0x0008B6C8 File Offset: 0x000898C8
		public unsafe bool CreateFromBpEffectActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_CreateFromBpEffectActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_CreateFromBpEffectActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06006180 RID: 24960 RVA: 0x0008B6D9 File Offset: 0x000898D9
		// (set) Token: 0x06006181 RID: 24961 RVA: 0x0008B6E9 File Offset: 0x000898E9
		public unsafe byte ContextType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_ContextType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_ContextType) = value;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06006182 RID: 24962 RVA: 0x0008B6FA File Offset: 0x000898FA
		// (set) Token: 0x06006183 RID: 24963 RVA: 0x0008B70A File Offset: 0x0008990A
		public unsafe int HitEffectType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_HitEffectType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_HitEffectType) = value;
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06006184 RID: 24964 RVA: 0x0008B71B File Offset: 0x0008991B
		// (set) Token: 0x06006185 RID: 24965 RVA: 0x0008B72F File Offset: 0x0008992F
		public unsafe FName AnsSlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_AnsSlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectContext.__PropertyOffset_AnsSlotName) = value;
			}
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x0008B744 File Offset: 0x00089944
		public FKuroEffectContext()
		{
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x0008B74C File Offset: 0x0008994C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectContext.StaticStruct();
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x0008B758 File Offset: 0x00089958
		[NullableContext(2)]
		public FKuroEffectContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x0008B762 File Offset: 0x00089962
		public FKuroEffectContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x0008B76D File Offset: 0x0008996D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectContext(Pointer, false, true);
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x0008B777 File Offset: 0x00089977
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400298D RID: 10637
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectContext";

		// Token: 0x0400298E RID: 10638
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400298F RID: 10639
		internal static int __PropertyOffset_EntityId;

		// Token: 0x04002990 RID: 10640
		internal static int __PropertyOffset_SourceObject;

		// Token: 0x04002991 RID: 10641
		internal static int __PropertyOffset_DisablePostProcess;

		// Token: 0x04002992 RID: 10642
		internal static int __PropertyOffset_CreateFromType;

		// Token: 0x04002993 RID: 10643
		internal static int __PropertyOffset_PlayFlag;

		// Token: 0x04002994 RID: 10644
		internal static int __PropertyOffset_EndInnerAnimNotifyStatesOnStop;

		// Token: 0x04002995 RID: 10645
		internal static int __PropertyOffset_CreateFromBpEffectActor;

		// Token: 0x04002996 RID: 10646
		internal static int __PropertyOffset_ContextType;

		// Token: 0x04002997 RID: 10647
		internal static int __PropertyOffset_HitEffectType;

		// Token: 0x04002998 RID: 10648
		internal static int __PropertyOffset_AnsSlotName;
	}
}
