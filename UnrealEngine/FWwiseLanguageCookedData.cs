using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A75 RID: 10869
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseFileHandler.WwiseLanguageCookedData")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FWwiseLanguageCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028142 RID: 164162 RVA: 0x003D018F File Offset: 0x003CE38F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseLanguageCookedData._ScriptStructPtr != 0) ? FWwiseLanguageCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseFileHandler.WwiseLanguageCookedData", ref FWwiseLanguageCookedData._ScriptStructPtr);
		}

		// Token: 0x17009909 RID: 39177
		// (get) Token: 0x06028143 RID: 164163 RVA: 0x003D01B3 File Offset: 0x003CE3B3
		// (set) Token: 0x06028144 RID: 164164 RVA: 0x003D01C3 File Offset: 0x003CE3C3
		public unsafe int LanguageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLanguageCookedData.__PropertyOffset_LanguageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLanguageCookedData.__PropertyOffset_LanguageId) = value;
			}
		}

		// Token: 0x1700990A RID: 39178
		// (get) Token: 0x06028145 RID: 164165 RVA: 0x003D01D4 File Offset: 0x003CE3D4
		// (set) Token: 0x06028146 RID: 164166 RVA: 0x003D01E8 File Offset: 0x003CE3E8
		public unsafe FName LanguageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLanguageCookedData.__PropertyOffset_LanguageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLanguageCookedData.__PropertyOffset_LanguageName) = value;
			}
		}

		// Token: 0x1700990B RID: 39179
		// (get) Token: 0x06028147 RID: 164167 RVA: 0x003D01FD File Offset: 0x003CE3FD
		// (set) Token: 0x06028148 RID: 164168 RVA: 0x003D020D File Offset: 0x003CE40D
		public unsafe EWwiseLanguageRequirement LanguageRequirement
		{
			get
			{
				return (EWwiseLanguageRequirement)(*(base.NativePtr + (IntPtr)FWwiseLanguageCookedData.__PropertyOffset_LanguageRequirement));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLanguageCookedData.__PropertyOffset_LanguageRequirement) = (byte)value;
			}
		}

		// Token: 0x06028149 RID: 164169 RVA: 0x003D021E File Offset: 0x003CE41E
		public FWwiseLanguageCookedData()
		{
		}

		// Token: 0x0602814A RID: 164170 RVA: 0x003D0226 File Offset: 0x003CE426
		public FWwiseLanguageCookedData(int LanguageId, FName LanguageName, EWwiseLanguageRequirement LanguageRequirement)
		{
			this.LanguageId = LanguageId;
			this.LanguageName = LanguageName;
			this.LanguageRequirement = LanguageRequirement;
		}

		// Token: 0x0602814B RID: 164171 RVA: 0x003D0243 File Offset: 0x003CE443
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseLanguageCookedData.StaticStruct();
		}

		// Token: 0x0602814C RID: 164172 RVA: 0x003D024F File Offset: 0x003CE44F
		[NullableContext(2)]
		public FWwiseLanguageCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602814D RID: 164173 RVA: 0x003D0259 File Offset: 0x003CE459
		public FWwiseLanguageCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602814E RID: 164174 RVA: 0x003D0264 File Offset: 0x003CE464
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseLanguageCookedData(Pointer, false, true);
		}

		// Token: 0x0602814F RID: 164175 RVA: 0x003D026E File Offset: 0x003CE46E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseLanguageCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04015FF2 RID: 90098
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseFileHandler.WwiseLanguageCookedData";

		// Token: 0x04015FF3 RID: 90099
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015FF4 RID: 90100
		internal static int __PropertyOffset_LanguageId;

		// Token: 0x04015FF5 RID: 90101
		internal static int __PropertyOffset_LanguageName;

		// Token: 0x04015FF6 RID: 90102
		internal static int __PropertyOffset_LanguageRequirement;
	}
}
