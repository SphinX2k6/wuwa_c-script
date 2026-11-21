using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002F6 RID: 758
	[UnrealObjectPath("/Script/KuroAnim.KuroBoneTranslationCurveExportInfo")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroBoneTranslationCurveExportInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600525E RID: 21086 RVA: 0x0007335C File Offset: 0x0007155C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBoneTranslationCurveExportInfo._ScriptStructPtr != 0) ? FKuroBoneTranslationCurveExportInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroBoneTranslationCurveExportInfo", ref FKuroBoneTranslationCurveExportInfo._ScriptStructPtr);
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x00073380 File Offset: 0x00071580
		// (set) Token: 0x06005260 RID: 21088 RVA: 0x00073394 File Offset: 0x00071594
		public unsafe FName CurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBoneTranslationCurveExportInfo.__PropertyOffset_CurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBoneTranslationCurveExportInfo.__PropertyOffset_CurveName) = value;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x000733A9 File Offset: 0x000715A9
		// (set) Token: 0x06005262 RID: 21090 RVA: 0x000733BD File Offset: 0x000715BD
		public unsafe FName SourceBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBoneTranslationCurveExportInfo.__PropertyOffset_SourceBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBoneTranslationCurveExportInfo.__PropertyOffset_SourceBoneName) = value;
			}
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x000733D2 File Offset: 0x000715D2
		public FKuroBoneTranslationCurveExportInfo()
		{
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x000733DA File Offset: 0x000715DA
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBoneTranslationCurveExportInfo.StaticStruct();
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x000733E6 File Offset: 0x000715E6
		[NullableContext(2)]
		public FKuroBoneTranslationCurveExportInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x000733F0 File Offset: 0x000715F0
		public FKuroBoneTranslationCurveExportInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x000733FB File Offset: 0x000715FB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBoneTranslationCurveExportInfo(Pointer, false, true);
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00073405 File Offset: 0x00071605
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBoneTranslationCurveExportInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04002188 RID: 8584
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.KuroBoneTranslationCurveExportInfo";

		// Token: 0x04002189 RID: 8585
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400218A RID: 8586
		internal static int __PropertyOffset_CurveName;

		// Token: 0x0400218B RID: 8587
		internal static int __PropertyOffset_SourceBoneName;
	}
}
