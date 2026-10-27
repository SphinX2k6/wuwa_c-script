using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009BE RID: 2494
	[UnrealObjectPath("/Script/Engine.DialogueVoice")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UDialogueVoice : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CCF RID: 36047 RVA: 0x000C983E File Offset: 0x000C7A3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDialogueVoice._ClassPtr;
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x000C984C File Offset: 0x000C7A4C
		public UDialogueVoice() : this(BuiltinUtils.AllocNativeUObject(UDialogueVoice.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CD1 RID: 36049 RVA: 0x000C9874 File Offset: 0x000C7A74
		[NullableContext(1)]
		public UDialogueVoice(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDialogueVoice.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06008CD2 RID: 36050 RVA: 0x000C98A7 File Offset: 0x000C7AA7
		// (set) Token: 0x06008CD3 RID: 36051 RVA: 0x000C98BB File Offset: 0x000C7ABB
		public unsafe TEnumAsByte<EGrammaticalGender> Gender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDialogueVoice.__PropertyOffset_Gender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDialogueVoice.__PropertyOffset_Gender) = value;
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x06008CD4 RID: 36052 RVA: 0x000C98D0 File Offset: 0x000C7AD0
		// (set) Token: 0x06008CD5 RID: 36053 RVA: 0x000C98E4 File Offset: 0x000C7AE4
		public unsafe TEnumAsByte<EGrammaticalNumber> Plurality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDialogueVoice.__PropertyOffset_Plurality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDialogueVoice.__PropertyOffset_Plurality) = value;
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x06008CD6 RID: 36054 RVA: 0x000C98F9 File Offset: 0x000C7AF9
		// (set) Token: 0x06008CD7 RID: 36055 RVA: 0x000C990D File Offset: 0x000C7B0D
		public unsafe FGuid LocalizationGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDialogueVoice.__PropertyOffset_LocalizationGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDialogueVoice.__PropertyOffset_LocalizationGUID) = value;
			}
		}

		// Token: 0x06008CD8 RID: 36056 RVA: 0x000C9922 File Offset: 0x000C7B22
		static UDialogueVoice()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DialogueVoice");
		}

		// Token: 0x06008CD9 RID: 36057 RVA: 0x000C9930 File Offset: 0x000C7B30
		protected UDialogueVoice(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042DC RID: 17116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DialogueVoice";

		// Token: 0x040042DD RID: 17117
		private static IntPtr _ClassPtr;

		// Token: 0x040042DE RID: 17118
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042DF RID: 17119
		internal static int __PropertyOffset_Gender;

		// Token: 0x040042E0 RID: 17120
		internal static int __PropertyOffset_Plurality;

		// Token: 0x040042E1 RID: 17121
		internal static int __PropertyOffset_LocalizationGUID;
	}
}
