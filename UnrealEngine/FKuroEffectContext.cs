using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018C7 RID: 6343
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectContext")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroEffectContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060176F9 RID: 95993 RVA: 0x002246AE File Offset: 0x002228AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectContext._ScriptStructPtr != 0) ? FKuroEffectContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectContext", ref FKuroEffectContext._ScriptStructPtr);
		}

		// Token: 0x17005E9D RID: 24221
		// (get) Token: 0x060176FA RID: 95994 RVA: 0x002246D2 File Offset: 0x002228D2
		// (set) Token: 0x060176FB RID: 95995 RVA: 0x002246E2 File Offset: 0x002228E2
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

		// Token: 0x17005E9E RID: 24222
		// (get) Token: 0x060176FC RID: 95996 RVA: 0x002246F3 File Offset: 0x002228F3
		// (set) Token: 0x060176FD RID: 95997 RVA: 0x00224707 File Offset: 0x00222907
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

		// Token: 0x17005E9F RID: 24223
		// (get) Token: 0x060176FE RID: 95998 RVA: 0x0022471C File Offset: 0x0022291C
		// (set) Token: 0x060176FF RID: 95999 RVA: 0x0022472C File Offset: 0x0022292C
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

		// Token: 0x17005EA0 RID: 24224
		// (get) Token: 0x06017700 RID: 96000 RVA: 0x0022473D File Offset: 0x0022293D
		// (set) Token: 0x06017701 RID: 96001 RVA: 0x0022474D File Offset: 0x0022294D
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

		// Token: 0x17005EA1 RID: 24225
		// (get) Token: 0x06017702 RID: 96002 RVA: 0x0022475E File Offset: 0x0022295E
		// (set) Token: 0x06017703 RID: 96003 RVA: 0x0022476E File Offset: 0x0022296E
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

		// Token: 0x17005EA2 RID: 24226
		// (get) Token: 0x06017704 RID: 96004 RVA: 0x0022477F File Offset: 0x0022297F
		// (set) Token: 0x06017705 RID: 96005 RVA: 0x0022478F File Offset: 0x0022298F
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

		// Token: 0x17005EA3 RID: 24227
		// (get) Token: 0x06017706 RID: 96006 RVA: 0x002247A0 File Offset: 0x002229A0
		// (set) Token: 0x06017707 RID: 96007 RVA: 0x002247B0 File Offset: 0x002229B0
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

		// Token: 0x17005EA4 RID: 24228
		// (get) Token: 0x06017708 RID: 96008 RVA: 0x002247C1 File Offset: 0x002229C1
		// (set) Token: 0x06017709 RID: 96009 RVA: 0x002247D1 File Offset: 0x002229D1
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

		// Token: 0x17005EA5 RID: 24229
		// (get) Token: 0x0601770A RID: 96010 RVA: 0x002247E2 File Offset: 0x002229E2
		// (set) Token: 0x0601770B RID: 96011 RVA: 0x002247F6 File Offset: 0x002229F6
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

		// Token: 0x0601770C RID: 96012 RVA: 0x0022480B File Offset: 0x00222A0B
		public FKuroEffectContext()
		{
		}

		// Token: 0x0601770D RID: 96013 RVA: 0x00224814 File Offset: 0x00222A14
		[NullableContext(1)]
		public FKuroEffectContext(int EntityId, UObject SourceObject, bool DisablePostProcess, int CreateFromType, int PlayFlag, bool CreateFromBpEffectActor, byte ContextType, int HitEffectType, FName AnsSlotName)
		{
			this.EntityId = EntityId;
			this.SourceObject = SourceObject;
			this.DisablePostProcess = DisablePostProcess;
			this.CreateFromType = CreateFromType;
			this.PlayFlag = PlayFlag;
			this.CreateFromBpEffectActor = CreateFromBpEffectActor;
			this.ContextType = ContextType;
			this.HitEffectType = HitEffectType;
			this.AnsSlotName = AnsSlotName;
		}

		// Token: 0x0601770E RID: 96014 RVA: 0x0022486C File Offset: 0x00222A6C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectContext.StaticStruct();
		}

		// Token: 0x0601770F RID: 96015 RVA: 0x00224878 File Offset: 0x00222A78
		[NullableContext(2)]
		public FKuroEffectContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017710 RID: 96016 RVA: 0x00224882 File Offset: 0x00222A82
		public FKuroEffectContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017711 RID: 96017 RVA: 0x0022488D File Offset: 0x00222A8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectContext(Pointer, false, true);
		}

		// Token: 0x06017712 RID: 96018 RVA: 0x00224897 File Offset: 0x00222A97
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400CBEC RID: 52204
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectContext";

		// Token: 0x0400CBED RID: 52205
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CBEE RID: 52206
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400CBEF RID: 52207
		internal static int __PropertyOffset_SourceObject;

		// Token: 0x0400CBF0 RID: 52208
		internal static int __PropertyOffset_DisablePostProcess;

		// Token: 0x0400CBF1 RID: 52209
		internal static int __PropertyOffset_CreateFromType;

		// Token: 0x0400CBF2 RID: 52210
		internal static int __PropertyOffset_PlayFlag;

		// Token: 0x0400CBF3 RID: 52211
		internal static int __PropertyOffset_CreateFromBpEffectActor;

		// Token: 0x0400CBF4 RID: 52212
		internal static int __PropertyOffset_ContextType;

		// Token: 0x0400CBF5 RID: 52213
		internal static int __PropertyOffset_HitEffectType;

		// Token: 0x0400CBF6 RID: 52214
		internal static int __PropertyOffset_AnsSlotName;
	}
}
