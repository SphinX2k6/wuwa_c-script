using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D22 RID: 3362
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LensSettings")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FLensSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B436 RID: 46134 RVA: 0x00100F33 File Offset: 0x000FF133
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLensSettings._ScriptStructPtr != 0) ? FLensSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LensSettings", ref FLensSettings._ScriptStructPtr);
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600B437 RID: 46135 RVA: 0x00100F58 File Offset: 0x000FF158
		// (set) Token: 0x0600B438 RID: 46136 RVA: 0x00100F9B File Offset: 0x000FF19B
		public FLensBloomSettings Bloom
		{
			get
			{
				base.FastCheckIsValid();
				FLensBloomSettings result;
				if ((result = this._Bloom) == null)
				{
					result = (this._Bloom = new FLensBloomSettings(base.NativePtr + (IntPtr)FLensSettings.__PropertyOffset_Bloom, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLensBloomSettings.StaticStruct(), base.NativePtr + (IntPtr)FLensSettings.__PropertyOffset_Bloom, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600B439 RID: 46137 RVA: 0x00100FBC File Offset: 0x000FF1BC
		// (set) Token: 0x0600B43A RID: 46138 RVA: 0x00100FFF File Offset: 0x000FF1FF
		public FLensImperfectionSettings Imperfections
		{
			get
			{
				base.FastCheckIsValid();
				FLensImperfectionSettings result;
				if ((result = this._Imperfections) == null)
				{
					result = (this._Imperfections = new FLensImperfectionSettings(base.NativePtr + (IntPtr)FLensSettings.__PropertyOffset_Imperfections, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLensImperfectionSettings.StaticStruct(), base.NativePtr + (IntPtr)FLensSettings.__PropertyOffset_Imperfections, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600B43B RID: 46139 RVA: 0x00101020 File Offset: 0x000FF220
		// (set) Token: 0x0600B43C RID: 46140 RVA: 0x00101030 File Offset: 0x000FF230
		public unsafe float ChromaticAberration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensSettings.__PropertyOffset_ChromaticAberration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensSettings.__PropertyOffset_ChromaticAberration) = value;
			}
		}

		// Token: 0x0600B43D RID: 46141 RVA: 0x00101041 File Offset: 0x000FF241
		public FLensSettings()
		{
		}

		// Token: 0x0600B43E RID: 46142 RVA: 0x00101049 File Offset: 0x000FF249
		public FLensSettings(FLensBloomSettings Bloom, FLensImperfectionSettings Imperfections, float ChromaticAberration)
		{
			this.Bloom = Bloom;
			this.Imperfections = Imperfections;
			this.ChromaticAberration = ChromaticAberration;
		}

		// Token: 0x0600B43F RID: 46143 RVA: 0x00101066 File Offset: 0x000FF266
		protected override IntPtr GetUStructPtr()
		{
			return FLensSettings.StaticStruct();
		}

		// Token: 0x0600B440 RID: 46144 RVA: 0x00101072 File Offset: 0x000FF272
		[NullableContext(2)]
		public FLensSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B441 RID: 46145 RVA: 0x0010107C File Offset: 0x000FF27C
		public FLensSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B442 RID: 46146 RVA: 0x00101087 File Offset: 0x000FF287
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLensSettings(Pointer, false, true);
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x00101091 File Offset: 0x000FF291
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLensSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04005EB1 RID: 24241
		public const string __ObjectPath = "/Script/Engine.LensSettings";

		// Token: 0x04005EB2 RID: 24242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005EB3 RID: 24243
		internal static int __PropertyOffset_Bloom;

		// Token: 0x04005EB4 RID: 24244
		[Nullable(2)]
		private FLensBloomSettings _Bloom;

		// Token: 0x04005EB5 RID: 24245
		internal static int __PropertyOffset_Imperfections;

		// Token: 0x04005EB6 RID: 24246
		[Nullable(2)]
		private FLensImperfectionSettings _Imperfections;

		// Token: 0x04005EB7 RID: 24247
		internal static int __PropertyOffset_ChromaticAberration;
	}
}
