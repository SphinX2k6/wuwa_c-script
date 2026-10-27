using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018C2 RID: 6338
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroCodeFunctionPayload")]
	[UnrealStructLayout(880, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 880)]
	public class FKuroCodeFunctionPayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060176B1 RID: 95921 RVA: 0x00223DB2 File Offset: 0x00221FB2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCodeFunctionPayload._ScriptStructPtr != 0) ? FKuroCodeFunctionPayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroCodeFunctionPayload", ref FKuroCodeFunctionPayload._ScriptStructPtr);
		}

		// Token: 0x17005E8E RID: 24206
		// (get) Token: 0x060176B2 RID: 95922 RVA: 0x00223DD8 File Offset: 0x00221FD8
		// (set) Token: 0x060176B3 RID: 95923 RVA: 0x00223E1B File Offset: 0x0022201B
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

		// Token: 0x17005E8F RID: 24207
		// (get) Token: 0x060176B4 RID: 95924 RVA: 0x00223E2C File Offset: 0x0022202C
		// (set) Token: 0x060176B5 RID: 95925 RVA: 0x00223E6F File Offset: 0x0022206F
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

		// Token: 0x17005E90 RID: 24208
		// (get) Token: 0x060176B6 RID: 95926 RVA: 0x00223E80 File Offset: 0x00222080
		// (set) Token: 0x060176B7 RID: 95927 RVA: 0x00223EC3 File Offset: 0x002220C3
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

		// Token: 0x17005E91 RID: 24209
		// (get) Token: 0x060176B8 RID: 95928 RVA: 0x00223ED4 File Offset: 0x002220D4
		// (set) Token: 0x060176B9 RID: 95929 RVA: 0x00223F17 File Offset: 0x00222117
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

		// Token: 0x17005E92 RID: 24210
		// (get) Token: 0x060176BA RID: 95930 RVA: 0x00223F28 File Offset: 0x00222128
		// (set) Token: 0x060176BB RID: 95931 RVA: 0x00223F6B File Offset: 0x0022216B
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

		// Token: 0x17005E93 RID: 24211
		// (get) Token: 0x060176BC RID: 95932 RVA: 0x00223F7C File Offset: 0x0022217C
		// (set) Token: 0x060176BD RID: 95933 RVA: 0x00223FBF File Offset: 0x002221BF
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

		// Token: 0x17005E94 RID: 24212
		// (get) Token: 0x060176BE RID: 95934 RVA: 0x00223FD0 File Offset: 0x002221D0
		// (set) Token: 0x060176BF RID: 95935 RVA: 0x00224013 File Offset: 0x00222213
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

		// Token: 0x17005E95 RID: 24213
		// (get) Token: 0x060176C0 RID: 95936 RVA: 0x00224024 File Offset: 0x00222224
		// (set) Token: 0x060176C1 RID: 95937 RVA: 0x00224067 File Offset: 0x00222267
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

		// Token: 0x17005E96 RID: 24214
		// (get) Token: 0x060176C2 RID: 95938 RVA: 0x00224078 File Offset: 0x00222278
		// (set) Token: 0x060176C3 RID: 95939 RVA: 0x002240BB File Offset: 0x002222BB
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

		// Token: 0x17005E97 RID: 24215
		// (get) Token: 0x060176C4 RID: 95940 RVA: 0x002240CC File Offset: 0x002222CC
		// (set) Token: 0x060176C5 RID: 95941 RVA: 0x0022410F File Offset: 0x0022230F
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

		// Token: 0x17005E98 RID: 24216
		// (get) Token: 0x060176C6 RID: 95942 RVA: 0x00224120 File Offset: 0x00222320
		// (set) Token: 0x060176C7 RID: 95943 RVA: 0x00224163 File Offset: 0x00222363
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

		// Token: 0x060176C8 RID: 95944 RVA: 0x00224171 File Offset: 0x00222371
		public FKuroCodeFunctionPayload()
		{
		}

		// Token: 0x060176C9 RID: 95945 RVA: 0x0022417C File Offset: 0x0022237C
		public FKuroCodeFunctionPayload(TMap<string, int> IntValues, TMap<string, long> Int64Values, TMap<string, float> FloatValues, TMap<string, bool> BoolValues, TMap<string, string> StringValues, TMap<string, FName> NameValues, TMap<string, FVector> VectorValues, TMap<string, FRotator> RotatorValues, TMap<string, FTransform> TransformValues, TMap<string, FGameplayTag> GameplayTagValues, TMap<string, UObject> ObjectValues)
		{
			this.IntValues = IntValues;
			this.Int64Values = Int64Values;
			this.FloatValues = FloatValues;
			this.BoolValues = BoolValues;
			this.StringValues = StringValues;
			this.NameValues = NameValues;
			this.VectorValues = VectorValues;
			this.RotatorValues = RotatorValues;
			this.TransformValues = TransformValues;
			this.GameplayTagValues = GameplayTagValues;
			this.ObjectValues = ObjectValues;
		}

		// Token: 0x060176CA RID: 95946 RVA: 0x002241E4 File Offset: 0x002223E4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCodeFunctionPayload.StaticStruct();
		}

		// Token: 0x060176CB RID: 95947 RVA: 0x002241F0 File Offset: 0x002223F0
		[NullableContext(2)]
		public FKuroCodeFunctionPayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060176CC RID: 95948 RVA: 0x002241FA File Offset: 0x002223FA
		public FKuroCodeFunctionPayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060176CD RID: 95949 RVA: 0x00224205 File Offset: 0x00222405
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCodeFunctionPayload(Pointer, false, true);
		}

		// Token: 0x060176CE RID: 95950 RVA: 0x0022420F File Offset: 0x0022240F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCodeFunctionPayload(Pointer, MemoryOwner);
		}

		// Token: 0x0400CBC5 RID: 52165
		public const string __ObjectPath = "/Script/KuroGameplay.KuroCodeFunctionPayload";

		// Token: 0x0400CBC6 RID: 52166
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CBC7 RID: 52167
		internal static int __PropertyOffset_IntValues;

		// Token: 0x0400CBC8 RID: 52168
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _IntValues;

		// Token: 0x0400CBC9 RID: 52169
		internal static int __PropertyOffset_Int64Values;

		// Token: 0x0400CBCA RID: 52170
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, long> _Int64Values;

		// Token: 0x0400CBCB RID: 52171
		internal static int __PropertyOffset_FloatValues;

		// Token: 0x0400CBCC RID: 52172
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _FloatValues;

		// Token: 0x0400CBCD RID: 52173
		internal static int __PropertyOffset_BoolValues;

		// Token: 0x0400CBCE RID: 52174
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, bool> _BoolValues;

		// Token: 0x0400CBCF RID: 52175
		internal static int __PropertyOffset_StringValues;

		// Token: 0x0400CBD0 RID: 52176
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _StringValues;

		// Token: 0x0400CBD1 RID: 52177
		internal static int __PropertyOffset_NameValues;

		// Token: 0x0400CBD2 RID: 52178
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FName> _NameValues;

		// Token: 0x0400CBD3 RID: 52179
		internal static int __PropertyOffset_VectorValues;

		// Token: 0x0400CBD4 RID: 52180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _VectorValues;

		// Token: 0x0400CBD5 RID: 52181
		internal static int __PropertyOffset_RotatorValues;

		// Token: 0x0400CBD6 RID: 52182
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FRotator> _RotatorValues;

		// Token: 0x0400CBD7 RID: 52183
		internal static int __PropertyOffset_TransformValues;

		// Token: 0x0400CBD8 RID: 52184
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FTransform> _TransformValues;

		// Token: 0x0400CBD9 RID: 52185
		internal static int __PropertyOffset_GameplayTagValues;

		// Token: 0x0400CBDA RID: 52186
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FGameplayTag> _GameplayTagValues;

		// Token: 0x0400CBDB RID: 52187
		internal static int __PropertyOffset_ObjectValues;

		// Token: 0x0400CBDC RID: 52188
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UObject> _ObjectValues;
	}
}
