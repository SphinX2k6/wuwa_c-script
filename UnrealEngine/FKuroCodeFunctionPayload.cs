using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003DD RID: 989
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroCodeFunctionPayload")]
	[UnrealStructLayout(880, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 880)]
	public class FKuroCodeFunctionPayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600612C RID: 24876 RVA: 0x0008ADB3 File Offset: 0x00088FB3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCodeFunctionPayload._ScriptStructPtr != 0) ? FKuroCodeFunctionPayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroCodeFunctionPayload", ref FKuroCodeFunctionPayload._ScriptStructPtr);
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x0600612D RID: 24877 RVA: 0x0008ADD8 File Offset: 0x00088FD8
		// (set) Token: 0x0600612E RID: 24878 RVA: 0x0008AE1B File Offset: 0x0008901B
		public TMap<string, int> IntValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._IntValues) == null)
				{
					result = (this._IntValues = new TMap<string, int>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_IntValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IntValues.CopyAssign(value);
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x0600612F RID: 24879 RVA: 0x0008AE2C File Offset: 0x0008902C
		// (set) Token: 0x06006130 RID: 24880 RVA: 0x0008AE6F File Offset: 0x0008906F
		public TMap<string, long> Int64Values
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, long> result;
				if ((result = this._Int64Values) == null)
				{
					result = (this._Int64Values = new TMap<string, long>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_Int64Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int64Values.CopyAssign(value);
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06006131 RID: 24881 RVA: 0x0008AE80 File Offset: 0x00089080
		// (set) Token: 0x06006132 RID: 24882 RVA: 0x0008AEC3 File Offset: 0x000890C3
		public TMap<string, float> FloatValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._FloatValues) == null)
				{
					result = (this._FloatValues = new TMap<string, float>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_FloatValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatValues.CopyAssign(value);
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x0008AED4 File Offset: 0x000890D4
		// (set) Token: 0x06006134 RID: 24884 RVA: 0x0008AF17 File Offset: 0x00089117
		public TMap<string, bool> BoolValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, bool> result;
				if ((result = this._BoolValues) == null)
				{
					result = (this._BoolValues = new TMap<string, bool>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_BoolValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoolValues.CopyAssign(value);
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06006135 RID: 24885 RVA: 0x0008AF28 File Offset: 0x00089128
		// (set) Token: 0x06006136 RID: 24886 RVA: 0x0008AF6B File Offset: 0x0008916B
		public TMap<string, string> StringValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._StringValues) == null)
				{
					result = (this._StringValues = new TMap<string, string>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_StringValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringValues.CopyAssign(value);
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06006137 RID: 24887 RVA: 0x0008AF7C File Offset: 0x0008917C
		// (set) Token: 0x06006138 RID: 24888 RVA: 0x0008AFBF File Offset: 0x000891BF
		public TMap<string, FName> NameValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FName> result;
				if ((result = this._NameValues) == null)
				{
					result = (this._NameValues = new TMap<string, FName>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_NameValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameValues.CopyAssign(value);
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06006139 RID: 24889 RVA: 0x0008AFD0 File Offset: 0x000891D0
		// (set) Token: 0x0600613A RID: 24890 RVA: 0x0008B013 File Offset: 0x00089213
		public TMap<string, FVector> VectorValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._VectorValues) == null)
				{
					result = (this._VectorValues = new TMap<string, FVector>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_VectorValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorValues.CopyAssign(value);
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600613B RID: 24891 RVA: 0x0008B024 File Offset: 0x00089224
		// (set) Token: 0x0600613C RID: 24892 RVA: 0x0008B067 File Offset: 0x00089267
		public TMap<string, FRotator> RotatorValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FRotator> result;
				if ((result = this._RotatorValues) == null)
				{
					result = (this._RotatorValues = new TMap<string, FRotator>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_RotatorValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotatorValues.CopyAssign(value);
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x0600613D RID: 24893 RVA: 0x0008B078 File Offset: 0x00089278
		// (set) Token: 0x0600613E RID: 24894 RVA: 0x0008B0BB File Offset: 0x000892BB
		public TMap<string, FTransform> TransformValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FTransform> result;
				if ((result = this._TransformValues) == null)
				{
					result = (this._TransformValues = new TMap<string, FTransform>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_TransformValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransformValues.CopyAssign(value);
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x0600613F RID: 24895 RVA: 0x0008B0CC File Offset: 0x000892CC
		// (set) Token: 0x06006140 RID: 24896 RVA: 0x0008B10F File Offset: 0x0008930F
		public TMap<string, FGameplayTag> GameplayTagValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FGameplayTag> result;
				if ((result = this._GameplayTagValues) == null)
				{
					result = (this._GameplayTagValues = new TMap<string, FGameplayTag>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_GameplayTagValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GameplayTagValues.CopyAssign(value);
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06006141 RID: 24897 RVA: 0x0008B120 File Offset: 0x00089320
		// (set) Token: 0x06006142 RID: 24898 RVA: 0x0008B163 File Offset: 0x00089363
		public TMap<string, UObject> ObjectValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UObject> result;
				if ((result = this._ObjectValues) == null)
				{
					result = (this._ObjectValues = new TMap<string, UObject>(base.NativePtr + (IntPtr)FKuroCodeFunctionPayload.__PropertyOffset_ObjectValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectValues.CopyAssign(value);
			}
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x0008B171 File Offset: 0x00089371
		public FKuroCodeFunctionPayload()
		{
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x0008B179 File Offset: 0x00089379
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCodeFunctionPayload.StaticStruct();
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x0008B185 File Offset: 0x00089385
		[NullableContext(2)]
		public FKuroCodeFunctionPayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x0008B18F File Offset: 0x0008938F
		public FKuroCodeFunctionPayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x0008B19A File Offset: 0x0008939A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCodeFunctionPayload(Pointer, false, true);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x0008B1A4 File Offset: 0x000893A4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCodeFunctionPayload(Pointer, MemoryOwner);
		}

		// Token: 0x04002966 RID: 10598
		public const string __ObjectPath = "/Script/KuroGameplay.KuroCodeFunctionPayload";

		// Token: 0x04002967 RID: 10599
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002968 RID: 10600
		internal static int __PropertyOffset_IntValues;

		// Token: 0x04002969 RID: 10601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _IntValues;

		// Token: 0x0400296A RID: 10602
		internal static int __PropertyOffset_Int64Values;

		// Token: 0x0400296B RID: 10603
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, long> _Int64Values;

		// Token: 0x0400296C RID: 10604
		internal static int __PropertyOffset_FloatValues;

		// Token: 0x0400296D RID: 10605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _FloatValues;

		// Token: 0x0400296E RID: 10606
		internal static int __PropertyOffset_BoolValues;

		// Token: 0x0400296F RID: 10607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, bool> _BoolValues;

		// Token: 0x04002970 RID: 10608
		internal static int __PropertyOffset_StringValues;

		// Token: 0x04002971 RID: 10609
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _StringValues;

		// Token: 0x04002972 RID: 10610
		internal static int __PropertyOffset_NameValues;

		// Token: 0x04002973 RID: 10611
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FName> _NameValues;

		// Token: 0x04002974 RID: 10612
		internal static int __PropertyOffset_VectorValues;

		// Token: 0x04002975 RID: 10613
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _VectorValues;

		// Token: 0x04002976 RID: 10614
		internal static int __PropertyOffset_RotatorValues;

		// Token: 0x04002977 RID: 10615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FRotator> _RotatorValues;

		// Token: 0x04002978 RID: 10616
		internal static int __PropertyOffset_TransformValues;

		// Token: 0x04002979 RID: 10617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FTransform> _TransformValues;

		// Token: 0x0400297A RID: 10618
		internal static int __PropertyOffset_GameplayTagValues;

		// Token: 0x0400297B RID: 10619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FGameplayTag> _GameplayTagValues;

		// Token: 0x0400297C RID: 10620
		internal static int __PropertyOffset_ObjectValues;

		// Token: 0x0400297D RID: 10621
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UObject> _ObjectValues;
	}
}
