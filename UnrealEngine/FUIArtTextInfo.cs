using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002124 RID: 8484
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIArtTextInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FUIArtTextInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FEA1 RID: 130721 RVA: 0x002F77FF File Offset: 0x002F59FF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUIArtTextInfo._ScriptStructPtr != 0) ? FUIArtTextInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.UIArtTextInfo", ref FUIArtTextInfo._ScriptStructPtr);
		}

		// Token: 0x17007D78 RID: 32120
		// (get) Token: 0x0601FEA2 RID: 130722 RVA: 0x002F7823 File Offset: 0x002F5A23
		// (set) Token: 0x0601FEA3 RID: 130723 RVA: 0x002F7837 File Offset: 0x002F5A37
		public unsafe string Character
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FUIArtTextInfo.__PropertyOffset_Character)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FUIArtTextInfo.__PropertyOffset_Character)), value);
			}
		}

		// Token: 0x17007D79 RID: 32121
		// (get) Token: 0x0601FEA4 RID: 130724 RVA: 0x002F784C File Offset: 0x002F5A4C
		// (set) Token: 0x0601FEA5 RID: 130725 RVA: 0x002F7860 File Offset: 0x002F5A60
		[Nullable(2)]
		public unsafe ULGUISpriteData_BaseObject SpriteData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + FUIArtTextInfo.__PropertyOffset_SpriteData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FUIArtTextInfo.__PropertyOffset_SpriteData, value);
			}
		}

		// Token: 0x0601FEA6 RID: 130726 RVA: 0x002F7875 File Offset: 0x002F5A75
		public FUIArtTextInfo()
		{
		}

		// Token: 0x0601FEA7 RID: 130727 RVA: 0x002F787D File Offset: 0x002F5A7D
		public FUIArtTextInfo(string Character, ULGUISpriteData_BaseObject SpriteData)
		{
			this.Character = Character;
			this.SpriteData = SpriteData;
		}

		// Token: 0x0601FEA8 RID: 130728 RVA: 0x002F7893 File Offset: 0x002F5A93
		protected override IntPtr GetUStructPtr()
		{
			return FUIArtTextInfo.StaticStruct();
		}

		// Token: 0x0601FEA9 RID: 130729 RVA: 0x002F789F File Offset: 0x002F5A9F
		[NullableContext(2)]
		public FUIArtTextInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FEAA RID: 130730 RVA: 0x002F78A9 File Offset: 0x002F5AA9
		public FUIArtTextInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FEAB RID: 130731 RVA: 0x002F78B4 File Offset: 0x002F5AB4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUIArtTextInfo(Pointer, false, true);
		}

		// Token: 0x0601FEAC RID: 130732 RVA: 0x002F78BE File Offset: 0x002F5ABE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUIArtTextInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401131C RID: 70428
		public const string __ObjectPath = "/Script/LGUI.UIArtTextInfo";

		// Token: 0x0401131D RID: 70429
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401131E RID: 70430
		internal static int __PropertyOffset_Character;

		// Token: 0x0401131F RID: 70431
		internal static int __PropertyOffset_SpriteData;
	}
}
