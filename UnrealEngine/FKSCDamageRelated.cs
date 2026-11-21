using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200055A RID: 1370
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCDamageRelated")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FKSCDamageRelated : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D37 RID: 32055 RVA: 0x000B9D83 File Offset: 0x000B7F83
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCDamageRelated._ScriptStructPtr != 0) ? FKSCDamageRelated._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCDamageRelated", ref FKSCDamageRelated._ScriptStructPtr);
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06007D38 RID: 32056 RVA: 0x000B9DA7 File Offset: 0x000B7FA7
		// (set) Token: 0x06007D39 RID: 32057 RVA: 0x000B9DB7 File Offset: 0x000B7FB7
		public unsafe float Amplify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_Amplify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_Amplify) = value;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06007D3A RID: 32058 RVA: 0x000B9DC8 File Offset: 0x000B7FC8
		// (set) Token: 0x06007D3B RID: 32059 RVA: 0x000B9DD8 File Offset: 0x000B7FD8
		public unsafe EKSC_AttrType RelatedProperty
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_RelatedProperty));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_RelatedProperty) = (byte)value;
			}
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06007D3C RID: 32060 RVA: 0x000B9DE9 File Offset: 0x000B7FE9
		// (set) Token: 0x06007D3D RID: 32061 RVA: 0x000B9DF9 File Offset: 0x000B7FF9
		public unsafe EKSC_AttrType MainDamageType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_MainDamageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_MainDamageType) = (byte)value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06007D3E RID: 32062 RVA: 0x000B9E0A File Offset: 0x000B800A
		// (set) Token: 0x06007D3F RID: 32063 RVA: 0x000B9E1A File Offset: 0x000B801A
		public unsafe EKSC_AttrType SubDamageType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_SubDamageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_SubDamageType) = (byte)value;
			}
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x000B9E2B File Offset: 0x000B802B
		public FKSCDamageRelated()
		{
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x000B9E33 File Offset: 0x000B8033
		protected override IntPtr GetUStructPtr()
		{
			return FKSCDamageRelated.StaticStruct();
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x000B9E3F File Offset: 0x000B803F
		[NullableContext(2)]
		public FKSCDamageRelated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x000B9E49 File Offset: 0x000B8049
		public FKSCDamageRelated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x000B9E54 File Offset: 0x000B8054
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCDamageRelated(Pointer, false, true);
		}

		// Token: 0x06007D45 RID: 32069 RVA: 0x000B9E5E File Offset: 0x000B805E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCDamageRelated(Pointer, MemoryOwner);
		}

		// Token: 0x04003696 RID: 13974
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSCDamageRelated";

		// Token: 0x04003697 RID: 13975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003698 RID: 13976
		internal static int __PropertyOffset_Amplify;

		// Token: 0x04003699 RID: 13977
		internal static int __PropertyOffset_RelatedProperty;

		// Token: 0x0400369A RID: 13978
		internal static int __PropertyOffset_MainDamageType;

		// Token: 0x0400369B RID: 13979
		internal static int __PropertyOffset_SubDamageType;
	}
}
