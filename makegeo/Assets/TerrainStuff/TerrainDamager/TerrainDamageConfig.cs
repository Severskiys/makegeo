﻿/*
	The following license supersedes all notices in the source code.

	Copyright (c) 2019 Kurt Dekker/PLBM Games All rights reserved.

	http://www.twitter.com/kurtdekker

	Redistribution and use in source and binary forms, with or without
	modification, are permitted provided that the following conditions are
	met:

	Redistributions of source code must retain the above copyright notice,
	this list of conditions and the following disclaimer.

	Redistributions in binary form must reproduce the above copyright
	notice, this list of conditions and the following disclaimer in the
	documentation and/or other materials provided with the distribution.

	Neither the name of the Kurt Dekker/PLBM Games nor the names of its
	contributors may be used to endorse or promote products derived from
	this software without specific prior written permission.

	THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS
	IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED
	TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
	PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
	HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
	SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
	TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
	PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
	LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
	NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
	SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TerrainDamageConfig : ScriptableObject
{
	public enum ProceduralHoleShape
	{
		RECTANGULAR,
		INVERTEDCONE,
	}

	[Header( "Randomly chosen radius:")]
	public float MinRadius;
	public float MaxRadius;

	[Header( "Randomly chosen depth:")]
	public float MinDepth;
	public float MaxDepth;

	[Header( "Set false to make terrain bumps instead of pits.")]
	public bool RemoveEarth;

	[Header( "Choose the procedural shape of the hole.")]
	public ProceduralHoleShape HoleShape;

	// future ideas:
	//	___	support for predetermined geometric shapes: flat depressions, bowls, V-ditches
	//	___	support a grayscale heightmap texture as the shape of the dent

	void Reset()
	{
		MinRadius = 2.0f;
		MaxRadius = 3.0f;

		MinDepth = 0.5f;
		MaxDepth = 0.8f;

		RemoveEarth = true;

		HoleShape = ProceduralHoleShape.INVERTEDCONE;
	}
}
