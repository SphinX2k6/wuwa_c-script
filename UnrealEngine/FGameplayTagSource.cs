using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013E7 RID: 5095
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagSource")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGameplayTagSource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060129F0 RID: 76272 RVA: 0x001B66E6 File Offset: 0x001B48E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagSource._ScriptStructPtr != 0) ? FGameplayTagSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagSource", ref FGameplayTagSource._ScriptStructPtr);
		}

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x060129F1 RID: 76273 RVA: 0x001B670A File Offset: 0x001B490A
		// (set) Token: 0x060129F2 RID: 76274 RVA: 0x001B671E File Offset: 0x001B491E
		public unsafe FName SourceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagSource.__PropertyOffset_SourceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagSource.__PropertyOffset_SourceName) = value;
			}
		}

		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x060129F3 RID: 76275 RVA: 0x001B6733 File Offset: 0x001B4933
		// (set) Token: 0x060129F4 RID: 76276 RVA: 0x001B6743 File Offset: 0x001B4943
		public unsafe EGameplayTagSourceType SourceType
		{
			get
			{
				return (EGameplayTagSourceType)(*(base.NativePtr + (IntPtr)FGameplayTagSource.__PropertyOffset_SourceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagSource.__PropertyOffset_SourceType) = (byte)value;
			}
		}

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x060129F5 RID: 76277 RVA: 0x001B6754 File Offset: 0x001B4954
		// (set) Token: 0x060129F6 RID: 76278 RVA: 0x001B6768 File Offset: 0x001B4968
		public unsafe UGameplayTagsList SourceTagList
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTagsList>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayTagSource.__PropertyOffset_SourceTagList);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayTagSource.__PropertyOffset_SourceTagList, value);
			}
		}

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x060129F7 RID: 76279 RVA: 0x001B677D File Offset: 0x001B497D
		// (set) Token: 0x060129F8 RID: 76280 RVA: 0x001B6791 File Offset: 0x001B4991
		public unsafe URestrictedGameplayTagsList SourceRestrictedTagList
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URestrictedGameplayTagsList>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayTagSource.__PropertyOffset_SourceRestrictedTagList);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayTagSource.__PropertyOffset_SourceRestrictedTagList, value);
			}
		}

		// Token: 0x060129F9 RID: 76281 RVA: 0x001B67A6 File Offset: 0x001B49A6
		public FGameplayTagSource()
		{
		}

		// Token: 0x060129FA RID: 76282 RVA: 0x001B67AE File Offset: 0x001B49AE
		[NullableContext(1)]
		public FGameplayTagSource(FName SourceName, EGameplayTagSourceType SourceType, UGameplayTagsList SourceTagList, URestrictedGameplayTagsList SourceRestrictedTagList)
		{
			this.SourceName = SourceName;
			this.SourceType = SourceType;
			this.SourceTagList = SourceTagList;
			this.SourceRestrictedTagList = SourceRestrictedTagList;
		}

		// Token: 0x060129FB RID: 76283 RVA: 0x001B67D3 File Offset: 0x001B49D3
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagSource.StaticStruct();
		}

		// Token: 0x060129FC RID: 76284 RVA: 0x001B67DF File Offset: 0x001B49DF
		public FGameplayTagSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060129FD RID: 76285 RVA: 0x001B67E9 File Offset: 0x001B49E9
		public FGameplayTagSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060129FE RID: 76286 RVA: 0x001B67F4 File Offset: 0x001B49F4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagSource(Pointer, false, true);
		}

		// Token: 0x060129FF RID: 76287 RVA: 0x001B67FE File Offset: 0x001B49FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagSource(Pointer, MemoryOwner);
		}

		// Token: 0x04009F2F RID: 40751
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagSource";

		// Token: 0x04009F30 RID: 40752
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009F31 RID: 40753
		internal static int __PropertyOffset_SourceName;

		// Token: 0x04009F32 RID: 40754
		internal static int __PropertyOffset_SourceType;

		// Token: 0x04009F33 RID: 40755
		internal static int __PropertyOffset_SourceTagList;

		// Token: 0x04009F34 RID: 40756
		internal static int __PropertyOffset_SourceRestrictedTagList;
	}
}
