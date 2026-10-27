using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001033 RID: 4147
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PreviewAttachedObjectPair")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FPreviewAttachedObjectPair : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E955 RID: 59733 RVA: 0x0015AA1C File Offset: 0x00158C1C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPreviewAttachedObjectPair._ScriptStructPtr != 0) ? FPreviewAttachedObjectPair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PreviewAttachedObjectPair", ref FPreviewAttachedObjectPair._ScriptStructPtr);
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600E956 RID: 59734 RVA: 0x0015AA40 File Offset: 0x00158C40
		// (set) Token: 0x0600E957 RID: 59735 RVA: 0x0015AA5F File Offset: 0x00158C5F
		public TSoftObjectPtr<UObject> AttachedObject
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)FPreviewAttachedObjectPair.__PropertyOffset_AttachedObject, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FPreviewAttachedObjectPair.__PropertyOffset_AttachedObject, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600E958 RID: 59736 RVA: 0x0015AA84 File Offset: 0x00158C84
		// (set) Token: 0x0600E959 RID: 59737 RVA: 0x0015AA98 File Offset: 0x00158C98
		[Nullable(2)]
		public unsafe UObject Object_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FPreviewAttachedObjectPair.__PropertyOffset_Object_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPreviewAttachedObjectPair.__PropertyOffset_Object_DEPRECATED, value);
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600E95A RID: 59738 RVA: 0x0015AAAD File Offset: 0x00158CAD
		// (set) Token: 0x0600E95B RID: 59739 RVA: 0x0015AAC1 File Offset: 0x00158CC1
		public unsafe FName AttachedTo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPreviewAttachedObjectPair.__PropertyOffset_AttachedTo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPreviewAttachedObjectPair.__PropertyOffset_AttachedTo) = value;
			}
		}

		// Token: 0x0600E95C RID: 59740 RVA: 0x0015AAD6 File Offset: 0x00158CD6
		public FPreviewAttachedObjectPair()
		{
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x0015AADE File Offset: 0x00158CDE
		public FPreviewAttachedObjectPair(TSoftObjectPtr<UObject> AttachedObject, UObject Object_DEPRECATED, FName AttachedTo)
		{
			this.AttachedObject = AttachedObject;
			this.Object_DEPRECATED = Object_DEPRECATED;
			this.AttachedTo = AttachedTo;
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x0015AAFB File Offset: 0x00158CFB
		protected override IntPtr GetUStructPtr()
		{
			return FPreviewAttachedObjectPair.StaticStruct();
		}

		// Token: 0x0600E95F RID: 59743 RVA: 0x0015AB07 File Offset: 0x00158D07
		[NullableContext(2)]
		public FPreviewAttachedObjectPair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E960 RID: 59744 RVA: 0x0015AB11 File Offset: 0x00158D11
		public FPreviewAttachedObjectPair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E961 RID: 59745 RVA: 0x0015AB1C File Offset: 0x00158D1C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPreviewAttachedObjectPair(Pointer, false, true);
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x0015AB26 File Offset: 0x00158D26
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPreviewAttachedObjectPair(Pointer, MemoryOwner);
		}

		// Token: 0x04007EAA RID: 32426
		public const string __ObjectPath = "/Script/Engine.PreviewAttachedObjectPair";

		// Token: 0x04007EAB RID: 32427
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007EAC RID: 32428
		internal static int __PropertyOffset_AttachedObject;

		// Token: 0x04007EAD RID: 32429
		internal static int __PropertyOffset_Object_DEPRECATED;

		// Token: 0x04007EAE RID: 32430
		internal static int __PropertyOffset_AttachedTo;
	}
}
