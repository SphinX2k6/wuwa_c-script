using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013E1 RID: 5089
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagQuery")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FGameplayTagQuery : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060129B0 RID: 76208 RVA: 0x001B6149 File Offset: 0x001B4349
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagQuery._ScriptStructPtr != 0) ? FGameplayTagQuery._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagQuery", ref FGameplayTagQuery._ScriptStructPtr);
		}

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x060129B1 RID: 76209 RVA: 0x001B616D File Offset: 0x001B436D
		// (set) Token: 0x060129B2 RID: 76210 RVA: 0x001B617D File Offset: 0x001B437D
		public unsafe int TokenStreamVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagQuery.__PropertyOffset_TokenStreamVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagQuery.__PropertyOffset_TokenStreamVersion) = value;
			}
		}

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x060129B3 RID: 76211 RVA: 0x001B6190 File Offset: 0x001B4390
		// (set) Token: 0x060129B4 RID: 76212 RVA: 0x001B61D3 File Offset: 0x001B43D3
		public TArray<FGameplayTag> TagDictionary
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._TagDictionary) == null)
				{
					result = (this._TagDictionary = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)FGameplayTagQuery.__PropertyOffset_TagDictionary, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TagDictionary.CopyAssign(value);
			}
		}

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x060129B5 RID: 76213 RVA: 0x001B61E4 File Offset: 0x001B43E4
		// (set) Token: 0x060129B6 RID: 76214 RVA: 0x001B6227 File Offset: 0x001B4427
		public TArray<byte> QueryTokenStream
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._QueryTokenStream) == null)
				{
					result = (this._QueryTokenStream = new TArray<byte>(base.NativePtr + (IntPtr)FGameplayTagQuery.__PropertyOffset_QueryTokenStream, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QueryTokenStream.CopyAssign(value);
			}
		}

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x060129B7 RID: 76215 RVA: 0x001B6235 File Offset: 0x001B4435
		// (set) Token: 0x060129B8 RID: 76216 RVA: 0x001B6249 File Offset: 0x001B4449
		public unsafe string UserDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayTagQuery.__PropertyOffset_UserDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayTagQuery.__PropertyOffset_UserDescription)), value);
			}
		}

		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x060129B9 RID: 76217 RVA: 0x001B625E File Offset: 0x001B445E
		// (set) Token: 0x060129BA RID: 76218 RVA: 0x001B6272 File Offset: 0x001B4472
		public unsafe string AutoDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayTagQuery.__PropertyOffset_AutoDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayTagQuery.__PropertyOffset_AutoDescription)), value);
			}
		}

		// Token: 0x060129BB RID: 76219 RVA: 0x001B6287 File Offset: 0x001B4487
		public FGameplayTagQuery()
		{
		}

		// Token: 0x060129BC RID: 76220 RVA: 0x001B628F File Offset: 0x001B448F
		public FGameplayTagQuery(int TokenStreamVersion, TArray<FGameplayTag> TagDictionary, TArray<byte> QueryTokenStream, string UserDescription, string AutoDescription)
		{
			this.TokenStreamVersion = TokenStreamVersion;
			this.TagDictionary = TagDictionary;
			this.QueryTokenStream = QueryTokenStream;
			this.UserDescription = UserDescription;
			this.AutoDescription = AutoDescription;
		}

		// Token: 0x060129BD RID: 76221 RVA: 0x001B62BC File Offset: 0x001B44BC
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagQuery.StaticStruct();
		}

		// Token: 0x060129BE RID: 76222 RVA: 0x001B62C8 File Offset: 0x001B44C8
		[NullableContext(2)]
		public FGameplayTagQuery(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060129BF RID: 76223 RVA: 0x001B62D2 File Offset: 0x001B44D2
		public FGameplayTagQuery(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060129C0 RID: 76224 RVA: 0x001B62DD File Offset: 0x001B44DD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagQuery(Pointer, false, true);
		}

		// Token: 0x060129C1 RID: 76225 RVA: 0x001B62E7 File Offset: 0x001B44E7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagQuery(Pointer, MemoryOwner);
		}

		// Token: 0x04009F0E RID: 40718
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagQuery";

		// Token: 0x04009F0F RID: 40719
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009F10 RID: 40720
		internal static int __PropertyOffset_TokenStreamVersion;

		// Token: 0x04009F11 RID: 40721
		internal static int __PropertyOffset_TagDictionary;

		// Token: 0x04009F12 RID: 40722
		[Nullable(2)]
		private TArray<FGameplayTag> _TagDictionary;

		// Token: 0x04009F13 RID: 40723
		internal static int __PropertyOffset_QueryTokenStream;

		// Token: 0x04009F14 RID: 40724
		[Nullable(2)]
		private TArray<byte> _QueryTokenStream;

		// Token: 0x04009F15 RID: 40725
		internal static int __PropertyOffset_UserDescription;

		// Token: 0x04009F16 RID: 40726
		internal static int __PropertyOffset_AutoDescription;
	}
}
