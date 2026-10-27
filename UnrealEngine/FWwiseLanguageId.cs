using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A89 RID: 10889
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseLanguageId")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWwiseLanguageId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602824C RID: 164428 RVA: 0x003D1608 File Offset: 0x003CF808
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseLanguageId._ScriptStructPtr != 0) ? FWwiseLanguageId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseLanguageId", ref FWwiseLanguageId._ScriptStructPtr);
		}

		// Token: 0x17009935 RID: 39221
		// (get) Token: 0x0602824D RID: 164429 RVA: 0x003D162C File Offset: 0x003CF82C
		// (set) Token: 0x0602824E RID: 164430 RVA: 0x003D163C File Offset: 0x003CF83C
		public unsafe int LanguageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLanguageId.__PropertyOffset_LanguageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLanguageId.__PropertyOffset_LanguageId) = value;
			}
		}

		// Token: 0x17009936 RID: 39222
		// (get) Token: 0x0602824F RID: 164431 RVA: 0x003D164D File Offset: 0x003CF84D
		// (set) Token: 0x06028250 RID: 164432 RVA: 0x003D1661 File Offset: 0x003CF861
		public unsafe FName LanguageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLanguageId.__PropertyOffset_LanguageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLanguageId.__PropertyOffset_LanguageName) = value;
			}
		}

		// Token: 0x06028251 RID: 164433 RVA: 0x003D1676 File Offset: 0x003CF876
		public FWwiseLanguageId()
		{
		}

		// Token: 0x06028252 RID: 164434 RVA: 0x003D167E File Offset: 0x003CF87E
		public FWwiseLanguageId(int LanguageId, FName LanguageName)
		{
			this.LanguageId = LanguageId;
			this.LanguageName = LanguageName;
		}

		// Token: 0x06028253 RID: 164435 RVA: 0x003D1694 File Offset: 0x003CF894
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseLanguageId.StaticStruct();
		}

		// Token: 0x06028254 RID: 164436 RVA: 0x003D16A0 File Offset: 0x003CF8A0
		[NullableContext(2)]
		public FWwiseLanguageId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028255 RID: 164437 RVA: 0x003D16AA File Offset: 0x003CF8AA
		public FWwiseLanguageId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028256 RID: 164438 RVA: 0x003D16B5 File Offset: 0x003CF8B5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseLanguageId(Pointer, false, true);
		}

		// Token: 0x06028257 RID: 164439 RVA: 0x003D16BF File Offset: 0x003CF8BF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseLanguageId(Pointer, MemoryOwner);
		}

		// Token: 0x04016057 RID: 90199
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseLanguageId";

		// Token: 0x04016058 RID: 90200
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016059 RID: 90201
		internal static int __PropertyOffset_LanguageId;

		// Token: 0x0401605A RID: 90202
		internal static int __PropertyOffset_LanguageName;
	}
}
