using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CF4 RID: 3316
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroMaterialVariantsInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroMaterialVariantsInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B010 RID: 45072 RVA: 0x000F9BE8 File Offset: 0x000F7DE8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialVariantsInfo._ScriptStructPtr != 0) ? FKuroMaterialVariantsInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMaterialVariantsInfo", ref FKuroMaterialVariantsInfo._ScriptStructPtr);
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x0600B011 RID: 45073 RVA: 0x000F9C0C File Offset: 0x000F7E0C
		// (set) Token: 0x0600B012 RID: 45074 RVA: 0x000F9C4F File Offset: 0x000F7E4F
		public TArray<FName> Keywords
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Keywords) == null)
				{
					result = (this._Keywords = new TArray<FName>(base.NativePtr + (IntPtr)FKuroMaterialVariantsInfo.__PropertyOffset_Keywords, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Keywords.CopyAssign(value);
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x0600B013 RID: 45075 RVA: 0x000F9C5D File Offset: 0x000F7E5D
		// (set) Token: 0x0600B014 RID: 45076 RVA: 0x000F9C71 File Offset: 0x000F7E71
		[Nullable(2)]
		public unsafe UMaterialInstance Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariantsInfo.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariantsInfo.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x000F9C86 File Offset: 0x000F7E86
		public FKuroMaterialVariantsInfo()
		{
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x000F9C8E File Offset: 0x000F7E8E
		public FKuroMaterialVariantsInfo(TArray<FName> Keywords, UMaterialInstance Material)
		{
			this.Keywords = Keywords;
			this.Material = Material;
		}

		// Token: 0x0600B017 RID: 45079 RVA: 0x000F9CA4 File Offset: 0x000F7EA4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialVariantsInfo.StaticStruct();
		}

		// Token: 0x0600B018 RID: 45080 RVA: 0x000F9CB0 File Offset: 0x000F7EB0
		[NullableContext(2)]
		public FKuroMaterialVariantsInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x000F9CBA File Offset: 0x000F7EBA
		public FKuroMaterialVariantsInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x000F9CC5 File Offset: 0x000F7EC5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialVariantsInfo(Pointer, false, true);
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x000F9CCF File Offset: 0x000F7ECF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialVariantsInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04005C2D RID: 23597
		public const string __ObjectPath = "/Script/Engine.KuroMaterialVariantsInfo";

		// Token: 0x04005C2E RID: 23598
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005C2F RID: 23599
		internal static int __PropertyOffset_Keywords;

		// Token: 0x04005C30 RID: 23600
		[Nullable(2)]
		private TArray<FName> _Keywords;

		// Token: 0x04005C31 RID: 23601
		internal static int __PropertyOffset_Material;
	}
}
