using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A93 RID: 10899
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseSharedLanguageId")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FWwiseSharedLanguageId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060282D3 RID: 164563 RVA: 0x003D2017 File Offset: 0x003D0217
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseSharedLanguageId._ScriptStructPtr != 0) ? FWwiseSharedLanguageId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseSharedLanguageId", ref FWwiseSharedLanguageId._ScriptStructPtr);
		}

		// Token: 0x1700994A RID: 39242
		// (get) Token: 0x060282D4 RID: 164564 RVA: 0x003D203B File Offset: 0x003D023B
		// (set) Token: 0x060282D5 RID: 164565 RVA: 0x003D204B File Offset: 0x003D024B
		public unsafe EWwiseLanguageRequirement LanguageRequirement
		{
			get
			{
				return (EWwiseLanguageRequirement)(*(base.NativePtr + (IntPtr)FWwiseSharedLanguageId.__PropertyOffset_LanguageRequirement));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseSharedLanguageId.__PropertyOffset_LanguageRequirement) = (byte)value;
			}
		}

		// Token: 0x060282D6 RID: 164566 RVA: 0x003D205C File Offset: 0x003D025C
		public FWwiseSharedLanguageId()
		{
		}

		// Token: 0x060282D7 RID: 164567 RVA: 0x003D2064 File Offset: 0x003D0264
		public FWwiseSharedLanguageId(EWwiseLanguageRequirement LanguageRequirement)
		{
			this.LanguageRequirement = LanguageRequirement;
		}

		// Token: 0x060282D8 RID: 164568 RVA: 0x003D2073 File Offset: 0x003D0273
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseSharedLanguageId.StaticStruct();
		}

		// Token: 0x060282D9 RID: 164569 RVA: 0x003D207F File Offset: 0x003D027F
		[NullableContext(2)]
		public FWwiseSharedLanguageId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060282DA RID: 164570 RVA: 0x003D2089 File Offset: 0x003D0289
		public FWwiseSharedLanguageId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060282DB RID: 164571 RVA: 0x003D2094 File Offset: 0x003D0294
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseSharedLanguageId(Pointer, false, true);
		}

		// Token: 0x060282DC RID: 164572 RVA: 0x003D209E File Offset: 0x003D029E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseSharedLanguageId(Pointer, MemoryOwner);
		}

		// Token: 0x04016086 RID: 90246
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseSharedLanguageId";

		// Token: 0x04016087 RID: 90247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016088 RID: 90248
		internal static int __PropertyOffset_LanguageRequirement;
	}
}
