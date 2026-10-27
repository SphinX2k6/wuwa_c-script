using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C03 RID: 7171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomSection")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UMovieSceneKuroMaterialParameterCustomSection : UMovieSceneParameterSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BAD6 RID: 113366 RVA: 0x0028BC00 File Offset: 0x00289E00
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroMaterialParameterCustomSection._ClassPtr;
		}

		// Token: 0x0601BAD7 RID: 113367 RVA: 0x0028BC0C File Offset: 0x00289E0C
		public UMovieSceneKuroMaterialParameterCustomSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialParameterCustomSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BAD8 RID: 113368 RVA: 0x0028BC34 File Offset: 0x00289E34
		public UMovieSceneKuroMaterialParameterCustomSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialParameterCustomSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006FA5 RID: 28581
		// (get) Token: 0x0601BAD9 RID: 113369 RVA: 0x0028BC68 File Offset: 0x00289E68
		// (set) Token: 0x0601BADA RID: 113370 RVA: 0x0028BCA1 File Offset: 0x00289EA1
		public TArray<FName> BodyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BodyNames) == null)
				{
					result = (this._BodyNames = new TArray<FName>(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialParameterCustomSection.__PropertyOffset_BodyNames, this));
				}
				return result;
			}
			set
			{
				this.BodyNames.CopyAssign(value);
			}
		}

		// Token: 0x17006FA6 RID: 28582
		// (get) Token: 0x0601BADB RID: 113371 RVA: 0x0028BCAF File Offset: 0x00289EAF
		// (set) Token: 0x0601BADC RID: 113372 RVA: 0x0028BCBF File Offset: 0x00289EBF
		public unsafe EKuroCharSlotSpecifiedType SlotType
		{
			get
			{
				return (EKuroCharSlotSpecifiedType)(*(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialParameterCustomSection.__PropertyOffset_SlotType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialParameterCustomSection.__PropertyOffset_SlotType) = (byte)value;
			}
		}

		// Token: 0x17006FA7 RID: 28583
		// (get) Token: 0x0601BADD RID: 113373 RVA: 0x0028BCD0 File Offset: 0x00289ED0
		// (set) Token: 0x0601BADE RID: 113374 RVA: 0x0028BD09 File Offset: 0x00289F09
		public TArray<string> CustomPartNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomPartNames) == null)
				{
					result = (this._CustomPartNames = new TArray<string>(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialParameterCustomSection.__PropertyOffset_CustomPartNames, this));
				}
				return result;
			}
			set
			{
				this.CustomPartNames.CopyAssign(value);
			}
		}

		// Token: 0x0601BADF RID: 113375 RVA: 0x0028BD17 File Offset: 0x00289F17
		static UMovieSceneKuroMaterialParameterCustomSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomSection");
		}

		// Token: 0x0601BAE0 RID: 113376 RVA: 0x0028BD25 File Offset: 0x00289F25
		protected UMovieSceneKuroMaterialParameterCustomSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE29 RID: 60969
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomSection";

		// Token: 0x0400EE2A RID: 60970
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE2B RID: 60971
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE2C RID: 60972
		internal static int __PropertyOffset_BodyNames;

		// Token: 0x0400EE2D RID: 60973
		[Nullable(2)]
		private TArray<FName> _BodyNames;

		// Token: 0x0400EE2E RID: 60974
		internal static int __PropertyOffset_SlotType;

		// Token: 0x0400EE2F RID: 60975
		internal static int __PropertyOffset_CustomPartNames;

		// Token: 0x0400EE30 RID: 60976
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomPartNames;
	}
}
