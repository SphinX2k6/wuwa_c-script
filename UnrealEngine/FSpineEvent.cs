using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028AF RID: 10415
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineEvent")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSpineEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060269D5 RID: 158165 RVA: 0x003AED34 File Offset: 0x003ACF34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpineEvent._ScriptStructPtr != 0) ? FSpineEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SpinePlugin.SpineEvent", ref FSpineEvent._ScriptStructPtr);
		}

		// Token: 0x170094DB RID: 38107
		// (get) Token: 0x060269D6 RID: 158166 RVA: 0x003AED58 File Offset: 0x003ACF58
		// (set) Token: 0x060269D7 RID: 158167 RVA: 0x003AED6C File Offset: 0x003ACF6C
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSpineEvent.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSpineEvent.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x170094DC RID: 38108
		// (get) Token: 0x060269D8 RID: 158168 RVA: 0x003AED81 File Offset: 0x003ACF81
		// (set) Token: 0x060269D9 RID: 158169 RVA: 0x003AED95 File Offset: 0x003ACF95
		public unsafe string StringValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSpineEvent.__PropertyOffset_StringValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSpineEvent.__PropertyOffset_StringValue)), value);
			}
		}

		// Token: 0x170094DD RID: 38109
		// (get) Token: 0x060269DA RID: 158170 RVA: 0x003AEDAA File Offset: 0x003ACFAA
		// (set) Token: 0x060269DB RID: 158171 RVA: 0x003AEDBA File Offset: 0x003ACFBA
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineEvent.__PropertyOffset_IntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineEvent.__PropertyOffset_IntValue) = value;
			}
		}

		// Token: 0x170094DE RID: 38110
		// (get) Token: 0x060269DC RID: 158172 RVA: 0x003AEDCB File Offset: 0x003ACFCB
		// (set) Token: 0x060269DD RID: 158173 RVA: 0x003AEDDB File Offset: 0x003ACFDB
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineEvent.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineEvent.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x170094DF RID: 38111
		// (get) Token: 0x060269DE RID: 158174 RVA: 0x003AEDEC File Offset: 0x003ACFEC
		// (set) Token: 0x060269DF RID: 158175 RVA: 0x003AEDFC File Offset: 0x003ACFFC
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineEvent.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineEvent.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x060269E0 RID: 158176 RVA: 0x003AEE0D File Offset: 0x003AD00D
		public FSpineEvent()
		{
		}

		// Token: 0x060269E1 RID: 158177 RVA: 0x003AEE15 File Offset: 0x003AD015
		public FSpineEvent(string Name, string StringValue, int IntValue, float FloatValue, float Time)
		{
			this.Name = Name;
			this.StringValue = StringValue;
			this.IntValue = IntValue;
			this.FloatValue = FloatValue;
			this.Time = Time;
		}

		// Token: 0x060269E2 RID: 158178 RVA: 0x003AEE42 File Offset: 0x003AD042
		protected override IntPtr GetUStructPtr()
		{
			return FSpineEvent.StaticStruct();
		}

		// Token: 0x060269E3 RID: 158179 RVA: 0x003AEE4E File Offset: 0x003AD04E
		[NullableContext(2)]
		public FSpineEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060269E4 RID: 158180 RVA: 0x003AEE58 File Offset: 0x003AD058
		public FSpineEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060269E5 RID: 158181 RVA: 0x003AEE63 File Offset: 0x003AD063
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpineEvent(Pointer, false, true);
		}

		// Token: 0x060269E6 RID: 158182 RVA: 0x003AEE6D File Offset: 0x003AD06D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpineEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04015354 RID: 86868
		public const string __ObjectPath = "/Script/SpinePlugin.SpineEvent";

		// Token: 0x04015355 RID: 86869
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015356 RID: 86870
		internal static int __PropertyOffset_Name;

		// Token: 0x04015357 RID: 86871
		internal static int __PropertyOffset_StringValue;

		// Token: 0x04015358 RID: 86872
		internal static int __PropertyOffset_IntValue;

		// Token: 0x04015359 RID: 86873
		internal static int __PropertyOffset_FloatValue;

		// Token: 0x0401535A RID: 86874
		internal static int __PropertyOffset_Time;
	}
}
