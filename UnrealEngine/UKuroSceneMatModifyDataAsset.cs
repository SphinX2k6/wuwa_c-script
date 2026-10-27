using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C7F RID: 7295
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSceneModifier.KuroSceneMatModifyDataAsset")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKuroSceneMatModifyDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C530 RID: 116016 RVA: 0x0029BEA7 File Offset: 0x0029A0A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneMatModifyDataAsset._ClassPtr;
		}

		// Token: 0x0601C531 RID: 116017 RVA: 0x0029BEB4 File Offset: 0x0029A0B4
		public UKuroSceneMatModifyDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneMatModifyDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C532 RID: 116018 RVA: 0x0029BEDC File Offset: 0x0029A0DC
		public UKuroSceneMatModifyDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneMatModifyDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007288 RID: 29320
		// (get) Token: 0x0601C533 RID: 116019 RVA: 0x0029BF10 File Offset: 0x0029A110
		// (set) Token: 0x0601C534 RID: 116020 RVA: 0x0029BF49 File Offset: 0x0029A149
		public TArray<FKuroSceneMatModifyData> MatModifyData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroSceneMatModifyData> result;
				if ((result = this._MatModifyData) == null)
				{
					result = (this._MatModifyData = new TArray<FKuroSceneMatModifyData>(base.NativePtr + (IntPtr)UKuroSceneMatModifyDataAsset.__PropertyOffset_MatModifyData, this));
				}
				return result;
			}
			set
			{
				this.MatModifyData.CopyAssign(value);
			}
		}

		// Token: 0x0601C535 RID: 116021 RVA: 0x0029BF57 File Offset: 0x0029A157
		static UKuroSceneMatModifyDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSceneModifier.KuroSceneMatModifyDataAsset");
		}

		// Token: 0x0601C536 RID: 116022 RVA: 0x0029BF65 File Offset: 0x0029A165
		protected UKuroSceneMatModifyDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F3A0 RID: 62368
		public new const string __ObjectPath = "/Script/KuroSceneModifier.KuroSceneMatModifyDataAsset";

		// Token: 0x0400F3A1 RID: 62369
		private static IntPtr _ClassPtr;

		// Token: 0x0400F3A2 RID: 62370
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F3A3 RID: 62371
		internal static int __PropertyOffset_MatModifyData;

		// Token: 0x0400F3A4 RID: 62372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroSceneMatModifyData> _MatModifyData;
	}
}
