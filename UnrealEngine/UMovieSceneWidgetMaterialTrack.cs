using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200298C RID: 10636
	[UnrealObjectPath("/Script/UMG.MovieSceneWidgetMaterialTrack")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UMovieSceneWidgetMaterialTrack : UMovieSceneMaterialTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060275C8 RID: 161224 RVA: 0x003C0280 File Offset: 0x003BE480
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneWidgetMaterialTrack._ClassPtr;
		}

		// Token: 0x060275C9 RID: 161225 RVA: 0x003C028C File Offset: 0x003BE48C
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneWidgetMaterialTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060275CA RID: 161226 RVA: 0x003C0294 File Offset: 0x003BE494
		public UMovieSceneWidgetMaterialTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneWidgetMaterialTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060275CB RID: 161227 RVA: 0x003C02BC File Offset: 0x003BE4BC
		[NullableContext(1)]
		public UMovieSceneWidgetMaterialTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneWidgetMaterialTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009743 RID: 38723
		// (get) Token: 0x060275CC RID: 161228 RVA: 0x003C02F0 File Offset: 0x003BE4F0
		// (set) Token: 0x060275CD RID: 161229 RVA: 0x003C0329 File Offset: 0x003BE529
		[Nullable(1)]
		public TArray<FName> BrushPropertyNamePath
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BrushPropertyNamePath) == null)
				{
					result = (this._BrushPropertyNamePath = new TArray<FName>(base.NativePtr + (IntPtr)UMovieSceneWidgetMaterialTrack.__PropertyOffset_BrushPropertyNamePath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BrushPropertyNamePath.CopyAssign(value);
			}
		}

		// Token: 0x17009744 RID: 38724
		// (get) Token: 0x060275CE RID: 161230 RVA: 0x003C0337 File Offset: 0x003BE537
		// (set) Token: 0x060275CF RID: 161231 RVA: 0x003C034B File Offset: 0x003BE54B
		public unsafe FName TrackName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneWidgetMaterialTrack.__PropertyOffset_TrackName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneWidgetMaterialTrack.__PropertyOffset_TrackName) = value;
			}
		}

		// Token: 0x060275D0 RID: 161232 RVA: 0x003C0360 File Offset: 0x003BE560
		static UMovieSceneWidgetMaterialTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MovieSceneWidgetMaterialTrack");
		}

		// Token: 0x060275D1 RID: 161233 RVA: 0x003C036E File Offset: 0x003BE56E
		protected UMovieSceneWidgetMaterialTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159D2 RID: 88530
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040159D3 RID: 88531
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.MovieSceneWidgetMaterialTrack";

		// Token: 0x040159D4 RID: 88532
		private static IntPtr _ClassPtr;

		// Token: 0x040159D5 RID: 88533
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040159D6 RID: 88534
		internal static int __PropertyOffset_BrushPropertyNamePath;

		// Token: 0x040159D7 RID: 88535
		[Nullable(2)]
		private TArray<FName> _BrushPropertyNamePath;

		// Token: 0x040159D8 RID: 88536
		internal static int __PropertyOffset_TrackName;
	}
}
