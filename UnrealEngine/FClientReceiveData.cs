using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000938 RID: 2360
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ClientReceiveData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FClientReceiveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600854C RID: 34124 RVA: 0x000BE1DE File Offset: 0x000BC3DE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClientReceiveData._ScriptStructPtr != 0) ? FClientReceiveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ClientReceiveData", ref FClientReceiveData._ScriptStructPtr);
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x0600854D RID: 34125 RVA: 0x000BE202 File Offset: 0x000BC402
		// (set) Token: 0x0600854E RID: 34126 RVA: 0x000BE216 File Offset: 0x000BC416
		public unsafe APlayerController LocalPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + FClientReceiveData.__PropertyOffset_LocalPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FClientReceiveData.__PropertyOffset_LocalPC, value);
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x0600854F RID: 34127 RVA: 0x000BE22B File Offset: 0x000BC42B
		// (set) Token: 0x06008550 RID: 34128 RVA: 0x000BE23F File Offset: 0x000BC43F
		public unsafe FName MessageType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClientReceiveData.__PropertyOffset_MessageType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClientReceiveData.__PropertyOffset_MessageType) = value;
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x000BE254 File Offset: 0x000BC454
		// (set) Token: 0x06008552 RID: 34130 RVA: 0x000BE264 File Offset: 0x000BC464
		public unsafe int MessageIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClientReceiveData.__PropertyOffset_MessageIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClientReceiveData.__PropertyOffset_MessageIndex) = value;
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06008553 RID: 34131 RVA: 0x000BE275 File Offset: 0x000BC475
		// (set) Token: 0x06008554 RID: 34132 RVA: 0x000BE289 File Offset: 0x000BC489
		[Nullable(1)]
		public unsafe string MessageString
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FClientReceiveData.__PropertyOffset_MessageString)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FClientReceiveData.__PropertyOffset_MessageString)), value);
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06008555 RID: 34133 RVA: 0x000BE29E File Offset: 0x000BC49E
		// (set) Token: 0x06008556 RID: 34134 RVA: 0x000BE2B2 File Offset: 0x000BC4B2
		public unsafe APlayerState RelatedPlayerState_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerState>(base.NativePtr / (IntPtr)sizeof(void*) + FClientReceiveData.__PropertyOffset_RelatedPlayerState_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FClientReceiveData.__PropertyOffset_RelatedPlayerState_1, value);
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06008557 RID: 34135 RVA: 0x000BE2C7 File Offset: 0x000BC4C7
		// (set) Token: 0x06008558 RID: 34136 RVA: 0x000BE2DB File Offset: 0x000BC4DB
		public unsafe APlayerState RelatedPlayerState_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerState>(base.NativePtr / (IntPtr)sizeof(void*) + FClientReceiveData.__PropertyOffset_RelatedPlayerState_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FClientReceiveData.__PropertyOffset_RelatedPlayerState_2, value);
			}
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06008559 RID: 34137 RVA: 0x000BE2F0 File Offset: 0x000BC4F0
		// (set) Token: 0x0600855A RID: 34138 RVA: 0x000BE304 File Offset: 0x000BC504
		public unsafe UObject OptionalObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FClientReceiveData.__PropertyOffset_OptionalObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FClientReceiveData.__PropertyOffset_OptionalObject, value);
			}
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x000BE319 File Offset: 0x000BC519
		public FClientReceiveData()
		{
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x000BE321 File Offset: 0x000BC521
		[NullableContext(1)]
		public FClientReceiveData(APlayerController LocalPC, FName MessageType, int MessageIndex, string MessageString, APlayerState RelatedPlayerState_1, APlayerState RelatedPlayerState_2, UObject OptionalObject)
		{
			this.LocalPC = LocalPC;
			this.MessageType = MessageType;
			this.MessageIndex = MessageIndex;
			this.MessageString = MessageString;
			this.RelatedPlayerState_1 = RelatedPlayerState_1;
			this.RelatedPlayerState_2 = RelatedPlayerState_2;
			this.OptionalObject = OptionalObject;
		}

		// Token: 0x0600855D RID: 34141 RVA: 0x000BE35E File Offset: 0x000BC55E
		protected override IntPtr GetUStructPtr()
		{
			return FClientReceiveData.StaticStruct();
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x000BE36A File Offset: 0x000BC56A
		public FClientReceiveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x000BE374 File Offset: 0x000BC574
		public FClientReceiveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008560 RID: 34144 RVA: 0x000BE37F File Offset: 0x000BC57F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClientReceiveData(Pointer, false, true);
		}

		// Token: 0x06008561 RID: 34145 RVA: 0x000BE389 File Offset: 0x000BC589
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClientReceiveData(Pointer, MemoryOwner);
		}

		// Token: 0x04003F70 RID: 16240
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ClientReceiveData";

		// Token: 0x04003F71 RID: 16241
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003F72 RID: 16242
		internal static int __PropertyOffset_LocalPC;

		// Token: 0x04003F73 RID: 16243
		internal static int __PropertyOffset_MessageType;

		// Token: 0x04003F74 RID: 16244
		internal static int __PropertyOffset_MessageIndex;

		// Token: 0x04003F75 RID: 16245
		internal static int __PropertyOffset_MessageString;

		// Token: 0x04003F76 RID: 16246
		internal static int __PropertyOffset_RelatedPlayerState_1;

		// Token: 0x04003F77 RID: 16247
		internal static int __PropertyOffset_RelatedPlayerState_2;

		// Token: 0x04003F78 RID: 16248
		internal static int __PropertyOffset_OptionalObject;
	}
}
