using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F55 RID: 3925
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleAttractorPointGravity")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UParticleModuleAttractorPointGravity : UParticleModuleAttractorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D3C6 RID: 54214 RVA: 0x00136C6F File Offset: 0x00134E6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAttractorPointGravity._ClassPtr;
		}

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x00136C7C File Offset: 0x00134E7C
		public UParticleModuleAttractorPointGravity() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorPointGravity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D3C8 RID: 54216 RVA: 0x00136CA4 File Offset: 0x00134EA4
		public UParticleModuleAttractorPointGravity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorPointGravity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600D3C9 RID: 54217 RVA: 0x00136CD7 File Offset: 0x00134ED7
		// (set) Token: 0x0600D3CA RID: 54218 RVA: 0x00136CEB File Offset: 0x00134EEB
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleAttractorPointGravity.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleAttractorPointGravity.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600D3CB RID: 54219 RVA: 0x00136D00 File Offset: 0x00134F00
		// (set) Token: 0x0600D3CC RID: 54220 RVA: 0x00136D10 File Offset: 0x00134F10
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleAttractorPointGravity.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleAttractorPointGravity.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600D3CD RID: 54221 RVA: 0x00136D21 File Offset: 0x00134F21
		// (set) Token: 0x0600D3CE RID: 54222 RVA: 0x00136D35 File Offset: 0x00134F35
		[Nullable(2)]
		public unsafe UDistributionFloat Strength_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleAttractorPointGravity.__PropertyOffset_Strength_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleAttractorPointGravity.__PropertyOffset_Strength_DEPRECATED, value);
			}
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0600D3CF RID: 54223 RVA: 0x00136D4C File Offset: 0x00134F4C
		// (set) Token: 0x0600D3D0 RID: 54224 RVA: 0x00136D85 File Offset: 0x00134F85
		public FRawDistributionFloat StrengthRaw
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._StrengthRaw) == null)
				{
					result = (this._StrengthRaw = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAttractorPointGravity.__PropertyOffset_StrengthRaw, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAttractorPointGravity.__PropertyOffset_StrengthRaw, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D3D1 RID: 54225 RVA: 0x00136DA6 File Offset: 0x00134FA6
		static UParticleModuleAttractorPointGravity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAttractorPointGravity");
		}

		// Token: 0x0600D3D2 RID: 54226 RVA: 0x00136DB4 File Offset: 0x00134FB4
		protected UParticleModuleAttractorPointGravity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040071CD RID: 29133
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAttractorPointGravity";

		// Token: 0x040071CE RID: 29134
		private static IntPtr _ClassPtr;

		// Token: 0x040071CF RID: 29135
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040071D0 RID: 29136
		internal static int __PropertyOffset_Position;

		// Token: 0x040071D1 RID: 29137
		internal static int __PropertyOffset_Radius;

		// Token: 0x040071D2 RID: 29138
		internal static int __PropertyOffset_Strength_DEPRECATED;

		// Token: 0x040071D3 RID: 29139
		internal static int __PropertyOffset_StrengthRaw;

		// Token: 0x040071D4 RID: 29140
		[Nullable(2)]
		private FRawDistributionFloat _StrengthRaw;
	}
}
